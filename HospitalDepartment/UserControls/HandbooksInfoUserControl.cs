using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Geomethod;
using Geomethod.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.UserControls
{
	public partial class HandbooksInfoUserControl : UserControl
	{
		bool loaded = false;
		Dictionary<Handbook, Control> binding = new Dictionary<Handbook, Control>();
		Dictionary<Handbook, int> rowBinding = new Dictionary<Handbook, int>();
		HandbooksInfo handbooksInfo;
		HandbookGroup handbookGroup;
		public void Init(HandbooksInfo handbooksInfo, HandbookGroup handbookGroup) { Init(handbooksInfo, handbookGroup, false);}
		public void Init(HandbooksInfo handbooksInfo,HandbookGroup handbookGroup, bool rareControl)
		{
			using (WaitCursor wc = new WaitCursor())
			{
				this.handbooksInfo = handbooksInfo;
				this.handbookGroup = handbookGroup;
				SuspendLayout();
				tlp.SuspendLayout();
				tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
				chkShowRare.Visible = rareControl;
				chkShowRare.Checked = !rareControl;
  			    tlp.Top = rareControl ? chkShowRare.Bottom + 6 : chkShowRare.Top;
				LoadData();
				ShowRare();
				FormUtils.Init(this);
				AutoScroll = false;
				tlp.ResumeLayout();
				foreach (Control ctl in binding.Values) if (ctl is ComboBox) (ctl as ComboBox).SelectionLength = 0;// selection bug fix
				ResumeLayout();
			}
		}

		public HandbooksInfoUserControl()
		{
			InitializeComponent();
		}

		private void HandbooksInfoUserControl_Load(object sender, EventArgs e)
		{
			if (DesignMode)
			{
//				base.BorderStyle = BorderStyle.FixedSingle;
				return;
			}

			loaded = true;
		}

		private void LoadData()
		{
			if (DesignMode || handbookGroup==null) return;
			tlp.Controls.Clear();
			binding.Clear();
			rowBinding.Clear();
			tlp.RowStyles.Clear();
			tlp.RowCount = handbookGroup.TotalVisibleCount+2;
			int row = 0;
			foreach (Handbook handbook in handbookGroup.GetAllHandbooks())
			{
				if (handbook.visible)
				{
					AddRow(handbook, row++);
				}
			}
		}

		Control AddRow(Handbook handbook, int row)
		{
			rowBinding.Add(handbook, row);
			Label label = new Label();
			label.AutoSize = true;
			label.Anchor = AnchorStyles.Left;
			tlp.Controls.Add(label, 0, row);
			if (handbook.handbookType == HandbookType.Header)
			{
				label.Text = ""+handbook.name;
				Font font=new Font(label.Font,FontStyle.Bold);
				label.Font = font;
				return label;
			}
			label.Text = handbook.name+':';
			Control ctl = null;
			string text=handbooksInfo.ContainsKey(handbook.id)?handbooksInfo[handbook.id]:handbook.GetDefaultValue();
			switch (handbook.handbookType)
			{
                case HandbookType.Date:
                    {
                        DateTimePicker dp = new DateTimePicker();
                        InitControl(dp, handbook, text);
                        ctl = dp;
                    }
                    break;
                case HandbookType.Number:
					if (handbook.nullable)
					{
						NullableNumericUserControl ucNullableNumeric = new NullableNumericUserControl();
                        InitControl(ucNullableNumeric.numericUpDown, handbook, text);
                        ucNullableNumeric.Text = text;
						ctl = ucNullableNumeric;
					}
					else
					{
						NumericUpDown nud = new NumericUpDown();
                        InitControl(nud, handbook, text);
						ctl = nud;
					}
					break;
				case HandbookType.String:
					if (handbook.Items.Count > 0)
					{
						if (handbook.IsMultiline)
						{
							MultilineComboUserControl uc = new MultilineComboUserControl();
							uc.LineCount = handbook.lineCount;
							uc.Additive = handbook.additive;
							uc.DataSource = handbook.Items;
							ctl = uc;
						}
						else
						{
							ComboBox cb = new ComboBox();
							cb.Items.AddRange(handbook.Items.ToArray());
							cb.SelectedItem = text;
							ctl = cb;
						}
					}
					else
					{
						TextBox tb = new TextBox();
						if (handbook.IsMultiline)
						{
							tb.Multiline = true;
							tb.Height *= handbook.lineCount;
						}
						ctl = tb;
					}
                    ctl.Text = text;
					break;
                default:
                    ctl.Text = text;
                    break;
			}
			if (ctl != null)
			{
				ctl.Width = App.GuiConfig.handbookControlWidth;
				tlp.Controls.Add(ctl, 1, row);
				binding.Add(handbook, ctl);
				return ctl;
			}
			return null;
		}

		decimal GetDecimal(string s, decimal defaultValue)
		{
			if (s!=null && s.Trim().Length > 0)
			{
				try
				{
					return decimal.Parse(s);
				}
				catch
				{
				}
			}
			return defaultValue;
		}

        private void InitControl(DateTimePicker dp, Handbook handbook, string text)
        {
            try
            {
                DateTime dt=DateTime.Now;
                dp.ShowCheckBox=handbook.nullable;
                bool hasVal = text != null && text.Trim().Length > 0 && DateTimeUtils.TryParse(text, out dt);
                if(dp.ShowCheckBox)
                {
                    dp.Checked = hasVal;
                }
                dp.Value = dt;
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

		private void InitControl(NumericUpDown nud, Handbook handbook, string text)
		{
			try
			{
				string defaultValue=handbook.GetDefaultValue();
				decimal min=GetDecimal(handbook.minValue, nud.Minimum);
				decimal max=GetDecimal(handbook.maxValue, nud.Maximum);
				decimal val = GetDecimal(defaultValue, nud.Minimum);
				if(val<min) val=min;
				if(max<min) max=min;
				if(max<val) max=val;
				nud.Minimum = min;
				nud.Maximum = max;
				nud.Value = val;
				nud.DecimalPlaces = handbook.decimalPlaces;
                nud.Text = text;
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
			}
		}

		internal void Save()
		{
			if (!loaded) return;
			foreach (KeyValuePair<Handbook, Control> pair in binding)
			{
                Handbook hb=pair.Key;
                Control ctl=pair.Value;
                string text=ctl.Text;
                if(hb.HandbookType==HandbookType.Date)
                {
                    DateTimePicker dp = (DateTimePicker)ctl;
                    if (dp.ShowCheckBox && !dp.Checked) text = "";
                    else text=DateTimeUtils.ToString(dp.Value);
                }
                handbooksInfo[hb.id] = text;
			}
		}

		private void ShowRare()
		{
			bool vis = chkShowRare.Checked;
			foreach (KeyValuePair<Handbook, int> pair in rowBinding)
			{
				Handbook hb = pair.Key;
				if (!hb.frequent)
				{
					int row = pair.Value;
					for (int col = 0; col < tlp.ColumnCount; col++)
					{
						Control ctl = tlp.GetControlFromPosition(col, row);
						if (ctl != null) ctl.Visible = vis;
					}
				}
			}
		}

		private void chkShowRare_CheckedChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			SuspendLayout();
			tlp.SuspendLayout();
			ShowRare();
			tlp.ResumeLayout();
//			foreach (Control ctl in binding.Values) if (ctl is ComboBox) (ctl as ComboBox).SelectionLength = 0;// selection bug fix
			ResumeLayout();
		}
	}
}
