using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Geomethod;

namespace CDUtils
{
	public class KSGTable
	{
		char sep;
		public KSGTable(char sep)
		{
			this.sep = sep;
		}
		public void Convert(string filePath, string targetFilePath)
		{
			List<string> sc=new List<string>(8);
			CsvConverter cc = new CsvConverter(sep);
			Console.WriteLine();
			using (StreamReader sr = new StreamReader(filePath,Encoding.Default))
			{
				using(StreamWriter sw=new StreamWriter(targetFilePath,false,Encoding.Default))
				{
					string s;
					int lineCount = 0;
					while ((s = sr.ReadLine()) != null)
					{
						Console.Write(string.Format("\r{0}",++lineCount));
						cc.Parse(s, sc);
					  if (sc.Count < 2) break;
						if (lineCount > 3)
						{
							string mkbString = sc[1];
							if (mkbString.Contains("-"))
							{
								mkbString=mkbString.Replace("-", " - ");
							}
							string[] ss = mkbString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							List<string> mkbs = new List<string>(ss);
							for (int i = mkbs.Count - 2; i > 0; i--)
							{
								if (mkbs[i] == "-")
									FixDefis(mkbs, i, s);
							}
							for (int i = 3; i <= 6; i++)
							{
								if (sc[i].Contains("-")) sc[i] = "0";
							}
							foreach (string mkb in mkbs)
							{
								sc[1] = mkb;
								sw.WriteLine(cc.ToCsvLine(sc));
							}
						}
						else
						{
							sw.WriteLine(cc.ToCsvLine(sc));
						}
					}
				}
			}
			Console.WriteLine();
		}

		private void FixDefis(List<string> mkbs, int index, string line)
		{
			string s1 = mkbs[index - 1];
			string s2 = mkbs[index + 1];
			mkbs.RemoveAt(index);
			mkbs.RemoveAt(index);
			int i1, i2;
			string prefix = GetPrefix(s1, out i1);
			string prefix2 = GetPrefix(s2, out i2);
//			if (prefix2 != prefix) throw new Exception("Ошибка в строке: " + line);
			for (int i = i2; i	> i1; i--)
			{
				string s = prefix + i;
				mkbs.Insert(index, s);
			}
		}

		string GetPrefix(string s, out int num)
		{
			string prefix = "";
			string number = "";
			foreach (char c in s)
			{
				if(Char.IsNumber(c)) number+=c;
				else prefix+=c;
			}
			num = int.Parse(number);
			return prefix;
		}
	}
}
