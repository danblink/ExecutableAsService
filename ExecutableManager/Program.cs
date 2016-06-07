using ExecutableLibrary;
using System;
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
			if (!File.Exists(Methods.ServicePath))
			{
				File.WriteAllBytes(Methods.ServicePath, Properties.Resources.ExecutableService);
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ManagerWindow());
		}
	}
}