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