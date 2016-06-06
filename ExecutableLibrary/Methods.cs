using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ExecutableLibrary
{
	public class Methods
	{
		private static string Common = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

		public static string MainDirectory {
			get {
				return Path.Combine(Common, "ExecutableAsServive");
			}
		}

		public static string GetDirectory(string name)
		{
			return MainDirectory + Path.DirectorySeparatorChar + name;
		}

		public static string GetService(string name)
		{
			return Path.Combine(GetDirectory(name), "ExecutableService.exe");
		}

		public static string GetExecutable(string name)
		{
			return Path.Combine(GetDirectory(name), "data.xml");
		}

		public static Executable ReadExecutable(string name)
		{
			FileStream stream = File.OpenRead(GetExecutable(name));
			Executable exec = new XmlSerializer(typeof(Executable)).Deserialize(stream) as Executable;
			stream.Close();
			return exec;
		}

		public static void SaveExecutable(Executable exec)
		{
			Directory.CreateDirectory(GetDirectory(exec.Name));
			FileStream stream = File.OpenWrite(GetExecutable(exec.Name));
			new XmlSerializer(typeof(Executable)).Serialize(stream, exec);
			stream.Close();
		}
	}
}