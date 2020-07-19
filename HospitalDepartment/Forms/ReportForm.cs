using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalDepartment.Reports;
using Microsoft.ReportingServices.ReportRendering;
using Microsoft.Reporting.WinForms;
using Geomethod;
using Geomethod.Windows.Forms;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;

namespace HospitalDepartment.Forms
{
	public partial class ReportForm : Form
	{
        Report report;
		public ReportForm(Report report, IReportBuilder rb)
		{
			InitializeComponent();
            this.report = report;
//            AddExtension(reportViewer, "HTML4", "HTML4", typeof(Microsoft.ReportingServices.Rendering.HtmlRenderer.Html40RenderingExtension));
            AddRenderingExtensions();

			base.Text = "Отчет - "+report.name;
			reportViewer.LocalReport.DisplayName = report.name;

			if (report.embeddedResource.Trim().Length > 0)
			{
				Assembly assembly=Assembly.GetAssembly(typeof(IReportBuilder));
				using (Stream stream = assembly.GetManifestResourceStream(report.embeddedResource))
				{
					reportViewer.LocalReport.LoadReportDefinition(stream);
				}
/*				using (Stream stream = assembly.GetManifestResourceStream("HospitalDepartment.Reports.PrescriptionsSubreport.rdlc"))
				{
					reportViewer.LocalReport.LoadSubreportDefinition("PrescriptionsSubreport", stream);
				}*/
			}
			else
			{
				reportViewer.LocalReport.ReportPath = PathUtils.BaseDirectory + report.path;
			}
			
			Dictionary<string, object> dataSources = rb.GetDataSources();
			if (dataSources != null)
			{
				foreach (string dsName in dataSources.Keys)
				{
					reportViewer.LocalReport.DataSources.Add(new ReportDataSource(dsName, dataSources[dsName]));
				}
			}

			Dictionary<string, string> parameters = rb.GetParameters();
			if (parameters != null)
			{
				ReportParameterInfoCollection coll=reportViewer.LocalReport.GetParameters();
				Dictionary<string,ReportParameterInfo> dict=new Dictionary<string,ReportParameterInfo>(coll.Count);
				foreach(ReportParameterInfo pi in coll) dict.Add(pi.Name,pi);
				
				List<ReportParameter> reportParams = new List<ReportParameter>();
				foreach (string key in parameters.Keys)
				{
					if(dict.ContainsKey(key))
					{
						string val = parameters[key];
						if (val == null) val = "";
						ReportParameter rp = new ReportParameter(key, val);
						reportParams.Add(rp);
					}
				}
				reportViewer.LocalReport.SetParameters(reportParams);
			}
		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			this.reportViewer.RefreshReport();
//            RenderingExtension[] list=reportViewer.LocalReport.ListRenderingExtensions();
		}

        private void AddRenderingExtensions()
        {
            const BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
            FieldInfo previewService = reportViewer.LocalReport.GetType().GetField("m_previewService", flags);
            MethodInfo listRenderingExtensions = previewService.FieldType.GetMethod("ListRenderingExtensions", flags);
            IList extensions = listRenderingExtensions.Invoke(previewService.GetValue(reportViewer.LocalReport), null) as IList;
            Assembly commonAssembly = typeof(IRenderingExtension).Assembly;
            // Now, get the LocalRenderingExtensionInfo type as it is defined in the same assembly.
            Type localRenderingExtensionInfoType = commonAssembly.GetType("Microsoft.Reporting.LocalRenderingExtensionInfo");
            foreach (object obj in extensions)
            {
                FieldInfo fi=obj.GetType().GetField("m_isVisible", BindingFlags.NonPublic | BindingFlags.Instance);
                FieldInfo fi2 = obj.GetType().GetField("m_isExposedExternally", BindingFlags.NonPublic | BindingFlags.Instance);
                fi.SetValue(obj,true);
                fi2.SetValue(obj,true);
//                PropertyInfo pi=localRenderingExtensionInfoType.GetProperty("IsVisible");
//                if(pi.CanWrite) pi.SetValue(obj, true, null);
            }
        }

        /// <summary>
        /// Adds the specified rendering extension to the specified ReportViewer instance.
        /// </summary>
        /// <param name="viewer">A ReportViewer control instance.</param>
        /// <param name="name">The name of the export format.</param>
        /// <param name="localizedName">The localized name of the export format that appears on the dropdown list.</param>
        /// <param name="extensionType">The class of the rendering extension to add.</param>

        private static void AddExtension(ReportViewer viewer, string name, string localizedName, Type extensionType)
        {
            const BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
            // CommonService.ListRenderingExtension is an internal method that returns a list of supported
            // rendering extensions. This list is also stored in a class field so we can simply get this list
            // and add Aspose.Words for Reporting Services rendering extensions to make Microsoft Word
            // export formats appear on the dropdown.
            // Get the service type.

            FieldInfo previewService = viewer.LocalReport.GetType().GetField("m_previewService", flags);

            // Get the ListRenderingExtensions method info.

            MethodInfo listRenderingExtensions = previewService.FieldType.GetMethod("ListRenderingExtensions", flags);
            // Obtan a list of existing rendering extensions.

            IList extensions = listRenderingExtensions.Invoke(previewService.GetValue(viewer.LocalReport), null) as IList;

            // LocalRenderingExtensionInfo is a class that holds information about a rendering extension.
            // We should create an instance of this class to add the info about the specified extension.
            // Since the IRenderingExtension interface is defined in the Microsoft.ReportViewer.Common 
            // assembly, use this trick to obtain the corresponding Assembly instance. This will work for 

            // both Report Viewer 2005 (8.0) and 2008 (9.0).

            Assembly commonAssembly = typeof(IRenderingExtension).Assembly;
            // Now, get the LocalRenderingExtensionInfo type as it is defined in the same assembly.
            Type localRenderingExtensionInfoType = commonAssembly.GetType("Microsoft.Reporting.LocalRenderingExtensionInfo");



            // Get the LocalRenderingExtensionInfo constructor info.

            ConstructorInfo ctor = localRenderingExtensionInfoType.GetConstructor(
                flags,
                null,
                new Type[] { typeof(string), typeof(string), typeof(bool), typeof(Type), typeof(bool) },
                null);

            // Create an instance of LocalRenderingExtensionInfo. 
            object instance = ctor.Invoke(new object[] { name, localizedName, true, extensionType, true });

            // Finally, add the info about our rendering extension to the list.
            extensions.Add(instance);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Export()
        {
            try
            {
                string filePath=reportViewer.LocalReport.DisplayName+".htm";
                dlgSaveFile.FileName = filePath;
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    using (WaitCursor wc = new WaitCursor())
                    {
                        string format = "HTML4.0";
                        string deviceInfo = null;// "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>";

                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        byte[] bytes = reportViewer.LocalReport.Render(
                           format, deviceInfo, out mimeType, out encoding, out extension,
                           out streamids, out warnings);

                        string text = System.Text.Encoding.UTF8.GetString(bytes);
                        while (RemoveScript(ref text)) { }
                        text = FixHtml(text);
                        File.WriteAllText(dlgSaveFile.FileName, text, Encoding.UTF8);
                        if (chkOpen.Checked)
                        {
                            Edit(dlgSaveFile.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }

        public static void Edit(string filePath)
        {
            if (filePath==null) filePath="";
            else if(filePath.Trim().Length>0) filePath = '"' + filePath + '"';
            System.Diagnostics.Process.Start(PathUtils.BaseDirectory + "HtmlEditor.exe", filePath);
        }

        private string FixHtml(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            sb.Replace("overflow:auto", "");
            sb.Replace("onscroll=\"ShowFixedHeaders()\"", "");
            sb.Replace("onresize=\"ShowFixedHeaders()\"", "");
            sb.Replace("onpropertychange=\"ShowFixedHeaders()\"", "");
            return sb.ToString();
        }

        bool RemoveScript(ref string text)
        {
            const string token1="<script";
            const string token2="/script>";
            int pos1=text.IndexOf(token1);
            if (pos1 > 0)
            {
                int pos2 = text.IndexOf(token2, pos1);
                if (pos2 > 0)
                {
                    text = text.Remove(pos1, pos2 - pos1 + token2.Length);
                    return true;
                }
            }
            return false;
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(null);
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }
	}
}