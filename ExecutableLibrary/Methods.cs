using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

		public static string ApplicationPath {
			get {
				return Path.Combine(MainDirectory, "ExecutableService.exe");
			}
		}

		public static string GetDirectory(string name)
		{
			return MainDirectory + Path.DirectorySeparatorChar + name;
		}

		public static string GetConfiguration(string name)
		{
			return GetDirectory(name) + ".bin";
		}

		public static Executable ReadConfiguration(string name)
		{
			FileStream stream = File.OpenRead(GetConfiguration(name));
			Executable exec = new BinaryFormatter().Deserialize(stream) as Executable;
			stream.Close();
			return exec;
		}

		public static void WriteConfiguration(Executable exec)
		{
			FileStream stream = File.OpenWrite(GetConfiguration(exec.Name));
			new BinaryFormatter().Serialize(stream, exec);
			stream.Close();
		}
	}
}