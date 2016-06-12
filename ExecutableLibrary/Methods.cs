using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Xml.Serialization;

namespace ExecutableLibrary
{
	public class Methods
	{
		// Some basic strings to help with other methods
		private static string Common = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
		public static string MainDirectory = Path.Combine(Common, "ExecutableAsServive");
		public static string ServicePath = Path.Combine(MainDirectory, "ExecutableService.exe");

		// Get the configuration file path by service name
		public static string GetConfig(string name)
		{
			return Path.Combine(MainDirectory, name + ".xml");
		}

		// Loads a single executable object from its configuration file
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

		// Saves an exectuable object to its configuration file
		public static void SaveExecutable(Executable executable)
		{
			File.Delete(GetConfig(executable.Name));
			using (FileStream stream = File.OpenWrite(GetConfig(executable.Name)))
			{
				new XmlSerializer(typeof(Executable)).Serialize(stream, executable);
			}
		}

		// Loads all the configuration files and gets their executable objects
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

		// Installs a service
		public static void InstallService(string name)
		{
			ServiceController service = ServiceController.GetServices().FirstOrDefault(exe => exe.ServiceName == name);
			if (service == null)
			{
				ManagedInstallerClass.InstallHelper(new string[] { "/Logfile", "/name=" + name, ServicePath });
			}
		}

		// Uninstalls a service
		public static void UninstallService(string name)
		{
			ServiceController service = ServiceController.GetServices().FirstOrDefault(exe => exe.ServiceName == name);
			if (service != null)
			{
				ManagedInstallerClass.InstallHelper(new string[] { "/u", "/Logfile", "/name=" + name, ServicePath });
				File.Delete(GetConfig(name));
			}
		}
	}
}