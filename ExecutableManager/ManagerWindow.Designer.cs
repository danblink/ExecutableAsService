namespace ExecutableManager
{
	partial class ManagerWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SaveButton = new System.Windows.Forms.Button();
			this.ExecutablesList = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrowseColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ArgumentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DirectoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AutoRestartColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ExecutablesList)).BeginInit();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SaveButton.Enabled = false;
			this.SaveButton.Location = new System.Drawing.Point(0, 421);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(843, 23);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.Text = "Save changes";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ExecutablesList
			// 
			this.ExecutablesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ExecutablesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PathColumn,
            this.BrowseColumn,
            this.ArgumentsColumn,
            this.DirectoryColumn,
            this.AutoRestartColumn});
			this.ExecutablesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExecutablesList.Location = new System.Drawing.Point(0, 0);
			this.ExecutablesList.Name = "ExecutablesList";
			this.ExecutablesList.Size = new System.Drawing.Size(843, 421);
			this.ExecutablesList.TabIndex = 1;
			this.ExecutablesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExecutablesList_CellContentClick);
			this.ExecutablesList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExecutablesList_CellValueChanged);
			this.ExecutablesList.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ExecutablesList_DefaultValuesNeeded);
			// 
			// NameColumn
			// 
			this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameColumn.DataPropertyName = "Name";
			this.NameColumn.HeaderText = "Name";
			this.NameColumn.Name = "NameColumn";
			// 
			// PathColumn
			// 
			this.PathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PathColumn.DataPropertyName = "Path";
			this.PathColumn.HeaderText = "Path";
			this.PathColumn.Name = "PathColumn";
			this.PathColumn.ReadOnly = true;
			// 
			// BrowseColumn
			// 
			this.BrowseColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.BrowseColumn.HeaderText = "Browse";
			this.BrowseColumn.Name = "BrowseColumn";
			this.BrowseColumn.Text = "Browse";
			this.BrowseColumn.UseColumnTextForButtonValue = true;
			this.BrowseColumn.Width = 48;
			// 
			// ArgumentsColumn
			// 
			this.ArgumentsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ArgumentsColumn.DataPropertyName = "Arguments";
			this.ArgumentsColumn.HeaderText = "Arguments";
			this.ArgumentsColumn.Name = "ArgumentsColumn";
			// 
			// DirectoryColumn
			// 
			this.DirectoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DirectoryColumn.DataPropertyName = "Directory";
			this.DirectoryColumn.HeaderText = "Directory";
			this.DirectoryColumn.Name = "DirectoryColumn";
			this.DirectoryColumn.Visible = false;
			// 
			// AutoRestartColumn
			// 
			this.AutoRestartColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.AutoRestartColumn.DataPropertyName = "AutoRestart";
			this.AutoRestartColumn.HeaderText = "Auto Restart";
			this.AutoRestartColumn.Name = "AutoRestartColumn";
			this.AutoRestartColumn.Width = 72;
			// 
			// ManagerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 444);
			this.Controls.Add(this.ExecutablesList);
			this.Controls.Add(this.SaveButton);
			this.Name = "ManagerWindow";
			this.Text = "Executables";
			((System.ComponentModel.ISupportInitialize)(this.ExecutablesList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.DataGridView ExecutablesList;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
		private System.Windows.Forms.DataGridViewButtonColumn BrowseColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ArgumentsColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DirectoryColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn AutoRestartColumn;
	}
}

