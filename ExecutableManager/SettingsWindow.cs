using ExecutableLibrary;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ExecutableManager
{
	public partial class SettingsWindow : Form
	{
		private Executable executable;

		public SettingsWindow(Executable exe = null)
		{
			executable = exe;
			InitializeComponent();

			PriorityBox.SelectedItem = ProcessPriorityClass.Normal.ToString();

			// Add all affinities into box
			for (int processor = 0; processor < Environment.ProcessorCount; processor++)
			{
				AffinityBox.Items.Add(processor);
				AffinityBox.SetSelected(processor, true);
			}
			
			if (exe != null)
			{
				NameBox.Text = exe.Name;
				PathBox.Text = exe.Path;
				DirectoryBox.Text = exe.Directory;
				ArgumentsBox.Text = exe.Arguments;
				PriorityBox.SelectedItem = exe.Priority.ToString();

				int mask = 1;
				for (int processor = 0; processor < Environment.ProcessorCount; processor++)
				{
					AffinityBox.SetSelected(processor, mask == (exe.Affinity & mask));
					mask <<= 1;
				}

				DeleteButton.Visible = true;
			}
		}

		private void PathButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = PathBox.Text;
			dialog.CheckPathExists = true;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				PathBox.Text = dialog.FileName;
				DirectoryBox.Text = Path.GetDirectoryName(PathBox.Text);
			}
		}

		private void DirectoryButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.SelectedPath = DirectoryBox.Text;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				DirectoryBox.Text = dialog.SelectedPath;
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Executable exe = new Executable();

			exe.Name = NameBox.Text;
			exe.Path = PathBox.Text;
			exe.Directory = DirectoryBox.Text;
			exe.Arguments = ArgumentsBox.Text;
			exe.Priority = (ProcessPriorityClass)Enum.Parse(typeof(ProcessPriorityClass), PriorityBox.Text);

			// Set affinity
			exe.Affinity = 0;
			foreach (int processor in AffinityBox.SelectedItems)
			{
				exe.Affinity |= (1 << processor);
			}

			Methods.SaveExecutable(exe);

			if (executable == null)
			{
				Methods.InstallService(exe.Name);
			}

			Close();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this executable?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Methods.UninstallService(executable.Name);
				Close();
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}