using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;
using HospitalDepartment.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class MultilineComboUserControl : UserControl
	{
		bool additive=false;
		int lineCount = 0;
		int lineHeight;

		const char sep = ',';
		public override string Text { get { return textBox.Text; } set { textBox.Text = value; } }
		public bool Additive { get { return additive; } set { additive = value; } }
		public int LineCount { get { return lineCount; } set { lineCount = value; } }
		public object DataSource { get { return comboBox.DataSource; } set { comboBox.DataSource = value; } }
		public MultilineComboUserControl()
		{
			InitializeComponent();
			textBox.Multiline = false;
			lineHeight = textBox.Height;
		}
		public void Init(string text, IEnumerable<string> items)
		{
			Text = text;
			DataSource = items;
			comboBox.Visible = items != null && items.GetEnumerator().MoveNext();
		}

		private void MultilineComboUserControl_Load(object sender, EventArgs e)
		{
			textBox.Multiline = lineCount != 1;
			OnResize();
		}
		void OnResize()
		{
			base.SuspendLayout();
			textBox.Left = 0;
			textBox.Top = 0;
			textBox.Width = panel.Left+1;
			if (lineCount==1)
			{
				textBox.Multiline = false;
				Height = textBox.Height;
			}
			else if (lineCount>1)
			{
				Height=lineCount*lineHeight;
				textBox.Height=Height;
			}
			else
			{
				textBox.Height = Height;
			}
			base.ResumeLayout();
		}

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddItem(comboBox.SelectedItem.ToString());
		}

		void AddItem(string item)
		{ 
			item=item.Trim();
			if (item.Length > 0)
			{
				if (additive)
				{
					string text = textBox.Text;
					foreach (string s in text.Split(sep))
					{
						if (string.Compare(s.Trim(), item, true) == 0) return;
					}
					if (text.Trim().Length > 0) text += sep + " ";
					text += item;
					textBox.Text = text;
				}
				else
				{
					textBox.Text = item;
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			TextForm form = new TextForm();
			form.TextValue = textBox.Text;
			if (form.ShowDialog() == DialogResult.OK)
			{
				textBox.Text = form.TextValue.Trim();
			}
		}

		private void MultilineComboUserControl_Resize(object sender, EventArgs e)
		{
			OnResize();
		}
	}
}
