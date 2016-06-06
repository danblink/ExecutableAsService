using System.IO;
using System.Reflection;
using System.ServiceProcess;

namespace ExecutableService
{
	static class Program
	{
		public static string GetServiceName()
		{
			return Path.GetFileName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
		}

		static void Main(string[] args)
		{
			ServiceBase.Run(new ExecutableService());
		}
	}
}