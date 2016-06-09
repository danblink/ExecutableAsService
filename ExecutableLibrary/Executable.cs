using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ExecutableLibrary
{
	[Serializable]
	public class Executable
	{
		[XmlIgnore]
		public string Name { get; set; }
		public string Path { get; set; }
		public string Arguments { get; set; }
		public string Directory { get; set; }
		public bool AutoRestart { get; set; }
		public IntPtr Affinity { get; set; }
		public ProcessPriorityClass Priority { get; set; }

		public Executable()
		{
			Path = "";
			Arguments = "";
			Directory = "";
			AutoRestart = true;
			Affinity = (IntPtr)0xff;
			Priority = ProcessPriorityClass.Normal;
		}
	}
}