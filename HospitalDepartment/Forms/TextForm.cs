using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Utils;

namespace HospitalDepartment.Forms
{
	public partial class TextForm : Form
	{
		int textBoxMinHeight;
		int textBoxHeight;
		int formHeight;
		public string TextValue { get { return textBox.Text; } set { textBox.Text = value; } }
		int FormMinHeight { get { return formHeight - (textBoxHeight - textBoxMinHeight); } }
        public bool ReadOnly 
        { 
            get { return textBox.ReadOnly; } 
            set 
            {
                bool readOnly=value;
                textBox.ReadOnly = readOnly;
                if (readOnly)
                {
                    btnSave.Text = "�������";
                    btnCancel.Visible = false;
                }
            } 
        }
        public bool Multiline 
		{ 
			get { return textBox.Multiline; } 
			set 
			{ 
				textBox.Multiline = value;
				if (Multiline)
				{
					MaximumSize = new Size(2048, 2048);
					this.Height = formHeight;
				}
				else
				{
					MaximumSize = new Size(2048, FormMinHeight);
					this.Height = FormMinHeight;
				}
			} 
		}

		public TextForm()
		{
			InitializeComponent();
			FormUtils.Init(this);
			textBoxHeight = textBox.Height;
			formHeight = Height;
			textBox.Multiline = false;
			textBoxMinHeight=textBox.Height;
			textBox.Multiline = true;
			MinimumSize = new Size(Width, FormMinHeight);
		}

		public TextForm(bool multiline): this()
		{
			Multiline = multiline;
		}

		private void TextForm_Load(object sender, EventArgs e)
		{

		}

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
	}
}