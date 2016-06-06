using ExecutableLibrary;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace ExecutableService
{
	partial class ExecutableService : ServiceBase
	{
		private bool running;
		private Executable exec;
		private Process program;
		private Thread thread;

		public ExecutableService()
		{
			ServiceName = Program.GetServiceName();
			running = false;
			program = new Process();
			thread = new Thread(new ThreadStart(RunThread));
			thread.IsBackground = true;
		}

		protected override void OnStart(string[] args)
		{
			exec = Methods.ReadExecutable(ServiceName);
			running = true;
			thread.Start();

			base.OnStart(args);
		}

		protected override void OnStop()
		{
			running = false;
			program.CloseMainWindow();
			if (!thread.Join(5000))
			{
				program.Kill();
				thread.Abort();
			}

			base.OnStop();
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
				exec = Methods.ReadExecutable(ServiceName);
			} while (running && exec.AutoRestart);
			// Repeat unless service was stopped or does not auto restart

			Stop();
		}
	}
}