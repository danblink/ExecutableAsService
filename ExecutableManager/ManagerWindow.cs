using ExecutableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ExecutableManager
{
	public partial class ManagerWindow : Form
	{
		BindingSource source;

		public ManagerWindow()
		{
			InitializeComponent();

			source = new BindingSource();
			ExecutableList.DataSource = source;
			ExecutableList.AutoGenerateColumns = false;

			Reload();

			Timer timer = new Timer();
			timer.Tick += delegate (object sender, EventArgs e)
			{
				Reload();
			};
			timer.Interval = 5000;
			timer.Start();
		}

		public void Reload()
		{
			List<Executable> executables = Methods.LoadAllExecutables();
			ServiceController[] services = ServiceController.GetServices();

			foreach (Executable executable in executables)
			{
				executable.Status = services.FirstOrDefault(exe => exe.ServiceName == executable.Name).Status;
			}

			EditButton.Enabled = executables.Count >= 1;

			source.DataSource = executables;
			ExecutableList.Refresh();
		}

		private void AddButton_Click(object sender, System.EventArgs e)
		{
			new SettingsWindow().ShowDialog();
			Reload();
		}

		private void ReloadButton_Click(object sender, System.EventArgs e)
		{
			Reload();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = ExecutableList.SelectedCells[0].OwningRow;
			Executable exe = row.DataBoundItem as Executable;
			new SettingsWindow(exe).ShowDialog();
			Reload();
		}
	}
}