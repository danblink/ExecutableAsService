using System.Diagnostics;
using System.ServiceProcess;

namespace ExecutableService
{
	static class Program
	{
		static void Main(string[] args)
		{
			ServiceBase.Run(new ExecutableService());
		}
	}
}