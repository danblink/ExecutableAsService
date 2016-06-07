using System;
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

		// Not implemented yet
		//public IntPtr Affinity { get; set; }
		//public ProcessPriorityClass Priority { get; set; }
	}
}