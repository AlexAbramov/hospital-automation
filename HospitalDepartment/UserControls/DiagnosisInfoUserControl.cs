using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Forms;

namespace HospitalDepartment.UserControls
{
	public partial class DiagnosisInfoUserControl : UserControl
	{
		public event EventHandler OnDiagnosisIdChanged;
		DiagnosisInfo diagnosisInfo = DiagnosisInfo.Empty;
		public DiagnosisInfo DiagnosisInfo { get { return diagnosisInfo;} }
		public void Init(DiagnosisInfo diagnosisInfo)
		{
			bool idChanged = this.diagnosisInfo.id != diagnosisInfo.id;
			this.diagnosisInfo = diagnosisInfo;
			textBox.Text = diagnosisInfo;
			lblCode.Text = CodeStr();
			if (idChanged && OnDiagnosisIdChanged!=null) OnDiagnosisIdChanged(null, null);
		}

		string CodeStr()
		{
			string s = diagnosisInfo.code;
			int l=diagnosisInfo.code.Length;
			if (l == 0) return "";
			int i=l/2;
			return s.Substring(0,i)+"\r\n"+s.Substring(i);
		}

		public DiagnosisInfoUserControl()
		{
			InitializeComponent();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			SelectDiagnosisForm form = new SelectDiagnosisForm(diagnosisInfo);
			if (form.ShowDialog() == DialogResult.OK)
			{
				Init(form.SelectedDiagnosisInfo);
			}
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			this.diagnosisInfo.text = textBox.Text.Trim();
		}

		private void DiagnosisInfoUserControl_Load(object sender, EventArgs e)
		{
		}

		private void DiagnosisInfoUserControl_Resize(object sender, EventArgs e)
		{
			OnResize();
		}

		void OnResize()
		{
/*			base.SuspendLayout();
			textBox.Left = 0;
			textBox.Top = 0;
			textBox.Width = Width - btnEditSize.Width;
			if (lineCount == 1)
			{
				textBox.Multiline = false;
				Height = textBox.Height;
			}
			else if (lineCount > 1)
			{
				Height = lineCount * lineHeight;
				textBox.Height = Height;
			}
			else
			{
				textBox.Height = Height;
			}
			btnEdit.Size = btnEditSize;
			btnEdit.Left = Width - btnEditSize.Width;
			btnEdit.Top = 0;
			base.ResumeLayout();*/
		}
	}
}
