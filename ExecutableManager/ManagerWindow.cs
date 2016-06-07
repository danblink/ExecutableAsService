using ExecutableLibrary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExecutableManager
{
	public partial class ManagerWindow : Form
	{
		private static List<Executable> executables = new List<Executable>();

		public ManagerWindow()
		{
			InitializeComponent();

			executables = Methods.LoadAllExecutables();

			BindingSource source = new BindingSource();
			source.DataSource = executables;
			ExecutablesList.DataSource = source;
		}

		private void ExecutablesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView grid = sender as DataGridView;
			if (e.RowIndex >= 0 && grid.Columns[e.ColumnIndex] == BrowseColumn)
			{
				DataGridViewRow row = grid.Rows[e.RowIndex];

				OpenFileDialog file = new OpenFileDialog();
				file.Title = "Select the executable you want to run as a service.";
				file.InitialDirectory = row.Cells["PathColumn"].Value as string;
				file.CheckFileExists = true;

				if (file.ShowDialog() == DialogResult.OK)
				{
					row.Cells["PathColumn"].Value = file.FileName;

					FolderBrowserDialog folder = new FolderBrowserDialog();
					folder.SelectedPath = Path.GetDirectoryName(file.FileName);
					folder.Description = "Select the working directory for the executable, or just press OK to use the executable's directory.";
					folder.ShowDialog();
					row.Cells["DirectoryColumn"].Value = folder.SelectedPath;
				}
			}
		}

		private void ExecutablesList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			SaveButton.Enabled = true;
		}

		private void ExecutablesList_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["BrowseColumn"].Value = "Browse";
			e.Row.Cells["ArgumentsColumn"].Value = "";
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show("Are you sure you want to apply these changes? Note that deleting a service is permentant, and that renaming a service requires deleting it and recreating it, so the program will be stopped in the process. Also note that deleting a service may take a few moments.", "", MessageBoxButtons.OKCancel))
			{
				List<Executable> current = Methods.LoadAllExecutables();

				foreach (Executable executable in executables)
				{
					// Validate service name
					if (executable.Name == null)
					{
						MessageBox.Show("A service was not given a name. Save aborted.");
						return;
					}

					// Validate service name
					char[] invalids = Path.GetInvalidPathChars();
					foreach (char invalid in invalids)
					{
						if (executable.Name.Contains(invalid + ""))
						{
							MessageBox.Show("The service name \"" + executable.Name + "\" is not valid. Save aborted.");
							return;
						}
					}

					// Validate executable path
					if (executable.Path == null || executable.Directory == null)
					{
						MessageBox.Show("The service \"" + executable.Name + "\" does not have a set path. Save aborted.");
						return;
					}

					// Save configuration
					Methods.SaveExecutable(executable);

					if (current.FirstOrDefault(exe => exe.Name == executable.Name) == null)
					{
						Methods.InstallService(executable.Name);
					}
				}

				foreach (Executable executable in current)
				{
					if (executables.FirstOrDefault(exe => exe.Name == executable.Name) == null)
					{
						Methods.UninstallService(executable.Name);
						File.Delete(Methods.GetConfig(executable.Name));
					}
				}

				MessageBox.Show("Save complete!");
			}
		}
	}
}