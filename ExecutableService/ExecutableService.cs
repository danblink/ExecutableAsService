using ExecutableLibrary;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace ExecutableService
{
	partial class ExecutableService : ServiceBase
	{
		/// <summary>
		///		ServiceBase overrides
		/// </summary>

		protected override void OnStart(string[] args)
		{
			StartService();
		}

		protected override void OnStop()
		{
			StopService();
		}

		/// <summary>
		///		Actual service stuff
		/// </summary>

		private bool running;
		private Executable exec;
		private Process program;
		private Thread thread;

		public ExecutableService()
		{
			running = false;
			program = new Process();
			thread = new Thread(new ThreadStart(RunThread));
			thread.IsBackground = true;
		}

		public void StartService()
		{
			exec = Methods.ReadConfiguration(ServiceName);
			running = true;
			thread.Start();
		}

		public void StopService()
		{
			running = false;
			program.CloseMainWindow();
			if (!thread.Join(5000))
			{
				program.Kill();
				thread.Abort();
			}
		}

		private void RunThread()
		{
			do
			{
				// Set start parameters
				program.StartInfo.FileName = exec.Path;
				program.StartInfo.Arguments = exec.Arguments;
				program.StartInfo.WorkingDirectory = exec.Directory;

				// Start the program
				program.Start();

				// Set running parameters
				// Not implemented yet
				//program.ProcessorAffinity = exec.Affinity;
				//program.PriorityClass = exec.Priority;

				// Pause until the program exits
				program.WaitForExit();
				Thread.Sleep(1000);

				// Reload data from config in case of changes
				exec = Methods.ReadConfiguration(ServiceName);
			} while (running && exec.AutoRestart);
			// Repeat unless service was stopped or does not auto restart
		}
	}
}