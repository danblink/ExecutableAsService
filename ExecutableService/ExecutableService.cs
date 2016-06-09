using ExecutableLibrary;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Threading;

namespace ExecutableService
{
	partial class ExecutableService : ServiceBase
	{
		private string name;
		private Executable executable;

		private bool running;
		private Process program;
		private Thread thread;

		protected override void OnStart(string[] args)
		{
			// Gets name of running service, code from StackOverflow
			string query = "SELECT * FROM Win32_Service where ProcessId = " + Process.GetCurrentProcess().Id;
			ManagementObjectCollection collection = new ManagementObjectSearcher(query).Get();
			name = collection.OfType<ManagementObject>().First()["name"].ToString();

			running = true;

			program = new Process();

			thread = new Thread(new ThreadStart(RunThread));
			thread.IsBackground = true;
			thread.Start();

			base.OnStart(args);
		}

		protected override void OnStop()
		{
			if (!program.HasExited)
			{
				running = false;
				program.CloseMainWindow();
				if (!thread.Join(5000))
				{
					program.Kill();
					thread.Abort();
				}
			}

			base.OnStop();
		}

		private void RunThread()
		{
			do
			{
				executable = Methods.LoadExecutable(name);

				// Set start parameters
				program.StartInfo.FileName = executable.Path;
				program.StartInfo.Arguments = executable.Arguments;
				program.StartInfo.WorkingDirectory = executable.Directory;

				// Start the program
				program.Start();

				// Set running parameters
				program.ProcessorAffinity = executable.Affinity;
				program.PriorityClass = executable.Priority;

				// Pause until the program exits
				program.WaitForExit();
				Thread.Sleep(1000);
			} while (running && executable.AutoRestart);
			// Repeat unless service was stopped or does not auto restart

			Stop();
		}
	}
}