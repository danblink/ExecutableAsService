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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ExecutableList = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SettingsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ControlColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.AddButton = new System.Windows.Forms.Button();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.ReloadButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ExecutableList)).BeginInit();
			this.SuspendLayout();
			// 
			// ExecutableList
			// 
			this.ExecutableList.AllowUserToAddRows = false;
			this.ExecutableList.AllowUserToDeleteRows = false;
			this.ExecutableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExecutableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ExecutableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SettingsColumn,
            this.StatusColumn,
            this.ControlColumn});
			this.ExecutableList.Location = new System.Drawing.Point(12, 12);
			this.ExecutableList.Name = "ExecutableList";
			this.ExecutableList.ReadOnly = true;
			this.ExecutableList.RowHeadersVisible = false;
			this.ExecutableList.Size = new System.Drawing.Size(344, 420);
			this.ExecutableList.TabIndex = 0;
			this.ExecutableList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExecutableList_CellContentClick);
			// 
			// NameColumn
			// 
			this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameColumn.DataPropertyName = "Name";
			this.NameColumn.HeaderText = "Name";
			this.NameColumn.Name = "NameColumn";
			this.NameColumn.ReadOnly = true;
			// 
			// SettingsColumn
			// 
			this.SettingsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.NullValue = "Settings";
			this.SettingsColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.SettingsColumn.HeaderText = "Settings";
			this.SettingsColumn.Name = "SettingsColumn";
			this.SettingsColumn.ReadOnly = true;
			this.SettingsColumn.Width = 51;
			// 
			// StatusColumn
			// 
			this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.StatusColumn.HeaderText = "Status";
			this.StatusColumn.Name = "StatusColumn";
			this.StatusColumn.ReadOnly = true;
			// 
			// ControlColumn
			// 
			this.ControlColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.NullValue = "Unavailable";
			this.ControlColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.ControlColumn.HeaderText = "Control";
			this.ControlColumn.Name = "ControlColumn";
			this.ControlColumn.ReadOnly = true;
			this.ControlColumn.Width = 46;
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddButton.Location = new System.Drawing.Point(12, 438);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RefreshButton
			// 
			this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshButton.Location = new System.Drawing.Point(281, 438);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(75, 23);
			this.RefreshButton.TabIndex = 2;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// ReloadButton
			// 
			this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ReloadButton.Location = new System.Drawing.Point(200, 438);
			this.ReloadButton.Name = "ReloadButton";
			this.ReloadButton.Size = new System.Drawing.Size(75, 23);
			this.ReloadButton.TabIndex = 3;
			this.ReloadButton.Text = "Reload";
			this.ReloadButton.UseVisualStyleBackColor = true;
			this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
			// 
			// ManagerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 473);
			this.Controls.Add(this.ReloadButton);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ExecutableList);
			this.Name = "ManagerWindow";
			this.Text = "Executables";
			this.Load += new System.EventHandler(this.ManagerWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.ExecutableList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ExecutableList;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewButtonColumn SettingsColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
		private System.Windows.Forms.DataGridViewButtonColumn ControlColumn;
		private System.Windows.Forms.Button ReloadButton;
	}
}

