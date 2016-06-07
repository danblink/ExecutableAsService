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
			string[] directories = Directory.GetDirectories(Methods.MainDirectory);
			foreach (string directory in directories)
			{
				if (File.Exists(Path.Combine(directory, "data.xml")))
				{
					executables.Add(Methods.ReadExecutable(Path.GetFileNameWithoutExtension(directory)));
				}
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