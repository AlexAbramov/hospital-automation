using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HospitalDepartment.Utils;
using Geomethod;

namespace HospitalDepartment.Forms
{
	partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			FormUtils.Init(this);

			//  Initialize the AboutBox to display the product information from the assembly information.
			//  Change assembly information settings for your application through either:
			//  - Project->Properties->Application->Assembly Information
			//  - AssemblyInfo.cs
			AssemblyInfo assemblyInfo = App.AssemblyInfo;
			this.Text = String.Format("О программе \"{0}\"", assemblyInfo.AssemblyTitle);
			this.labelProductName.Text = assemblyInfo.AssemblyProduct;
			this.labelVersion.Text = String.Format("Версия {0}", assemblyInfo.AssemblyVersion);
			this.labelCopyright.Text = assemblyInfo.AssemblyCopyright;
			//			this.labelCompanyName.Text = AssemblyUtils.AssemblyCompany;
			this.textBoxDescription.Text = assemblyInfo.AssemblyDescription;
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{

		}
	}
}
