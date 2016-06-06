using System;
using System.Diagnostics;

namespace ExecutableLibrary
{
	[Serializable]
	public class Executable
	{
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