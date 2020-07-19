using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalDepartment.Forms;
using Geomethod;
using Geomethod.Windows.Forms;

namespace HospitalDepartment
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
//!!!				string userAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
//				string commonAppData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				Application.EnableVisualStyles();
				if (App.Init())
				{
					Application.Run(new MainForm());
				}
			}
			catch (Exception ex)
			{
				try
				{
					Log.Exception(ex);
				}
				catch
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
	}
}