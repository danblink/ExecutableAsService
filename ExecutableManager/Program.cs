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
			File.WriteAllBytes(Methods.ApplicationPath, Properties.Resources.ExecutableService);
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ManagerWindow());
		}

		public static List<Executable> LoadList()
		{
			List<Executable> executables = new List<Executable>();
			string[] files = Directory.GetFiles(Methods.MainDirectory, "*.bin");
			foreach (string file in files)
			{
				executables.Add(Methods.ReadConfiguration(Path.GetFileNameWithoutExtension(file)));
			}
			return executables;
		}
	}
}