using ExecutableLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExecutableManager
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Directory.CreateDirectory(Methods.MainDirectory);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ManagerWindow());
		}

		public static List<Executable> LoadList()
		{
			List<Executable> executables = new List<Executable>();
			string[] files = Directory.GetDirectories(Methods.MainDirectory);
			foreach (string file in files)
			{
				executables.Add(Methods.ReadExecutable(Path.GetFileNameWithoutExtension(file)));
			}
			return executables;
		}

		public static void WriteService(string name)
		{
			Directory.CreateDirectory(Methods.GetDirectory(name));
			File.WriteAllBytes(Methods.GetService(name), Properties.Resources.ExecutableService);
		}
	}
}