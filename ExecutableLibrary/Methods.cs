using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.IO;
using System.Xml.Serialization;

namespace ExecutableLibrary
{
	public class Methods
	{
		// The common application data folder, where the service folder is stored
		private static string Common = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

		// The main directory where the service runs and configurations are stored
		public static string MainDirectory = Path.Combine(Common, "ExecutableAsServive");

		// The service exectuable path
		public static string ServicePath = Path.Combine(MainDirectory, "ExecutableService.exe");

		// Get the configuration file path by service name
		public static string GetConfig(string name)
		{
			return Path.Combine(MainDirectory, name + ".xml");
		}

		public static Executable LoadExecutable(string name)
		{
			Executable executable;
			using (FileStream stream = File.OpenRead(GetConfig(name)))
			{
				executable = new XmlSerializer(typeof(Executable)).Deserialize(stream) as Executable;
				executable.Name = name;
			}
			return executable;
		}

		public static void SaveExecutable(Executable executable)
		{
			File.Delete(GetConfig(executable.Name));
			using (FileStream stream = File.OpenWrite(GetConfig(executable.Name)))
			{
				new XmlSerializer(typeof(Executable)).Serialize(stream, executable);
			}
		}

		public static List<Executable> LoadAllExecutables()
		{
			List<Executable> executables = new List<Executable>();
			string[] files = Directory.GetFiles(MainDirectory, "*.xml");
			foreach (string file in files)
			{
				executables.Add(LoadExecutable(Path.GetFileNameWithoutExtension(file)));
			}
			return executables;
		}

		public static void InstallService(string name)
		{
			ManagedInstallerClass.InstallHelper(new string[] { "/Logfile", "/name=" + name, ServicePath });
		}

		public static void UninstallService(string name)
		{
			ManagedInstallerClass.InstallHelper(new string[] { "/u", "/Logfile", "/name=" + name, ServicePath });
		}
	}
}