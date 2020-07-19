using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDepartment
{
	public class HospitalDepartmentException : Exception
	{
		public HospitalDepartmentException(string msg)
			: base(msg)
		{
		}
		public HospitalDepartmentException(string msg, Exception innerException)
			: base(msg, innerException)
		{
		}
	}

	public class GenderUtils
	{
		public static string GetEndingOi(GenderId genderId) { return GetString(genderId, "��", "��"); }
		public static string GetEndingA(GenderId genderId) { return GetString(genderId, "", "�"); }
		public static string GetEndingGo(GenderId genderId) { return GetString(genderId, "��", "�"); }
		public static string GetGender(GenderId genderId) { return GetString(genderId, "�������", "�������"); }
		public static string GetString(GenderId genderId, string maleString, string femaleString)
		{
			switch (genderId)
			{
				case GenderId.Male: return maleString;
				case GenderId.Female: return femaleString;
			}
			return "";
		}
	}
}
