using System;
using System.Collections.Generic;
using System.Text;

namespace CDUtils
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				switch (args[0].ToLower())
				{
					case "/ksg":
						KSGTable t = new KSGTable(';');
						t.Convert(args[1], args[2]);
						break;
					default:
						HelpInfo();
						break;
				}
			}
			else HelpInfo();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		private static void HelpInfo()
		{
			Console.WriteLine("Usage: cdutils.exe /ksg inputFile outputFile");
		}
	}
}
