using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace ExecutableService
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : Installer
	{
		private ServiceProcessInstaller serviceProcessInstaller;
		private ServiceInstaller serviceInstaller;

		public ProjectInstaller()
		{
			serviceProcessInstaller = new ServiceProcessInstaller();
			serviceProcessInstaller.Account = ServiceAccount.LocalSystem;

			serviceInstaller = new ServiceInstaller();
			serviceInstaller.StartType = ServiceStartMode.Automatic;
			serviceInstaller.ServiceName = Program.GetServiceName();

			Installers.AddRange(new Installer[] {
				serviceProcessInstaller,
				serviceInstaller
			});
		}

		protected override void OnBeforeInstall(IDictionary savedState)
		{
			//serviceInstaller.ServiceName = Context.Parameters["name"];
			base.OnBeforeInstall(savedState);
		}

		protected override void OnBeforeUninstall(IDictionary savedState)
		{
			//serviceInstaller.ServiceName = Context.Parameters["name"];
			base.OnBeforeUninstall(savedState);
		}
	}
}