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
				RefreshStatus();
			};
			timer.Interval = 5000;
			timer.Start();
		}

		private void ManagerWindow_Load(object sender, EventArgs e)
		{
			RefreshStatus();
		}

		public void Reload()
		{
			List<Executable> executables = Methods.LoadAllExecutables();
			ServiceController[] services = ServiceController.GetServices();

			foreach (Executable executable in executables)
			{
				executable.Service = services.FirstOrDefault(exe => exe.ServiceName == executable.Name);
			}

			source.DataSource = executables;
			ExecutableList.Refresh();
		}

		public void RefreshStatus()
		{
			foreach (DataGridViewRow row in ExecutableList.Rows)
			{
				Executable executable = row.DataBoundItem as Executable;
				if (executable.Service != null)
				{
					row.Cells["StatusColumn"].Value = executable.Service.Status.ToString();
					switch (executable.Service.Status)
					{
						case ServiceControllerStatus.Running:
							row.Cells["ControlColumn"].Value = "Stop";
							break;
						case ServiceControllerStatus.Stopped:
							row.Cells["ControlColumn"].Value = "Start";
							break;
						default:
							row.Cells["ControlColumn"].Value = "Error";
							break;
					}
				}
				else
				{
					row.Cells["StatusColumn"].Value = "Error";
					row.Cells["ControlColumn"].Value = "Error";
				}
			}
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

		private void RefreshButton_Click(object sender, System.EventArgs e)
		{
			RefreshStatus();
		}

		private void ExecutableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridView grid = sender as DataGridView;
				DataGridViewColumn column = grid.Columns[e.ColumnIndex];
				Executable exe = grid.Rows[e.RowIndex].DataBoundItem as Executable;

				if (column == SettingsColumn)
				{
					new SettingsWindow(exe).ShowDialog();
					Reload();
				}
				else if (column == ControlColumn)
				{
					if (exe.Service.Status == ServiceControllerStatus.Running)
					{
						exe.Service.Stop();
					}
					else if (exe.Service.Status == ServiceControllerStatus.Stopped)
					{
						exe.Service.Start();
					}
				}
			}
		}
	}
}