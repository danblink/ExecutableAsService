namespace ExecutableManager
{
	partial class SettingsWindow
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
			this.BasicGroup = new System.Windows.Forms.GroupBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.PathLabel = new System.Windows.Forms.Label();
			this.AutoRestartBox = new System.Windows.Forms.CheckBox();
			this.DirectoryLabel = new System.Windows.Forms.Label();
			this.ArgumentsLabel = new System.Windows.Forms.Label();
			this.DirectoryBox = new System.Windows.Forms.TextBox();
			this.ArgumentsBox = new System.Windows.Forms.TextBox();
			this.DirectoryButton = new System.Windows.Forms.Button();
			this.PathButton = new System.Windows.Forms.Button();
			this.PathBox = new System.Windows.Forms.TextBox();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.AdvancedGroup = new System.Windows.Forms.GroupBox();
			this.AffinityBox = new System.Windows.Forms.ListBox();
			this.PriorityBox = new System.Windows.Forms.ComboBox();
			this.AffinityLabel = new System.Windows.Forms.Label();
			this.PriorityLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SettingsCancelButton = new System.Windows.Forms.Button();
			this.BasicGroup.SuspendLayout();
			this.AdvancedGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// BasicGroup
			// 
			this.BasicGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BasicGroup.Controls.Add(this.NameLabel);
			this.BasicGroup.Controls.Add(this.PathLabel);
			this.BasicGroup.Controls.Add(this.AutoRestartBox);
			this.BasicGroup.Controls.Add(this.DirectoryLabel);
			this.BasicGroup.Controls.Add(this.ArgumentsLabel);
			this.BasicGroup.Controls.Add(this.DirectoryBox);
			this.BasicGroup.Controls.Add(this.ArgumentsBox);
			this.BasicGroup.Controls.Add(this.DirectoryButton);
			this.BasicGroup.Controls.Add(this.PathButton);
			this.BasicGroup.Controls.Add(this.PathBox);
			this.BasicGroup.Controls.Add(this.NameBox);
			this.BasicGroup.Location = new System.Drawing.Point(12, 12);
			this.BasicGroup.Name = "BasicGroup";
			this.BasicGroup.Size = new System.Drawing.Size(344, 193);
			this.BasicGroup.TabIndex = 0;
			this.BasicGroup.TabStop = false;
			this.BasicGroup.Text = "Basic Settings";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(63, 24);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 13;
			this.NameLabel.Text = "Name";
			// 
			// PathLabel
			// 
			this.PathLabel.AutoSize = true;
			this.PathLabel.Location = new System.Drawing.Point(69, 53);
			this.PathLabel.Name = "PathLabel";
			this.PathLabel.Size = new System.Drawing.Size(29, 13);
			this.PathLabel.TabIndex = 12;
			this.PathLabel.Text = "Path";
			// 
			// AutoRestartBox
			// 
			this.AutoRestartBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AutoRestartBox.AutoSize = true;
			this.AutoRestartBox.Checked = true;
			this.AutoRestartBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoRestartBox.Location = new System.Drawing.Point(253, 23);
			this.AutoRestartBox.Name = "AutoRestartBox";
			this.AutoRestartBox.Size = new System.Drawing.Size(85, 17);
			this.AutoRestartBox.TabIndex = 11;
			this.AutoRestartBox.Text = "Auto Restart";
			this.AutoRestartBox.UseVisualStyleBackColor = true;
			// 
			// DirectoryLabel
			// 
			this.DirectoryLabel.AutoSize = true;
			this.DirectoryLabel.Location = new System.Drawing.Point(6, 82);
			this.DirectoryLabel.Name = "DirectoryLabel";
			this.DirectoryLabel.Size = new System.Drawing.Size(92, 13);
			this.DirectoryLabel.TabIndex = 10;
			this.DirectoryLabel.Text = "Working Directory";
			// 
			// ArgumentsLabel
			// 
			this.ArgumentsLabel.AutoSize = true;
			this.ArgumentsLabel.Location = new System.Drawing.Point(41, 109);
			this.ArgumentsLabel.Name = "ArgumentsLabel";
			this.ArgumentsLabel.Size = new System.Drawing.Size(57, 13);
			this.ArgumentsLabel.TabIndex = 9;
			this.ArgumentsLabel.Text = "Arguments";
			// 
			// DirectoryBox
			// 
			this.DirectoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DirectoryBox.Location = new System.Drawing.Point(104, 79);
			this.DirectoryBox.Name = "DirectoryBox";
			this.DirectoryBox.ReadOnly = true;
			this.DirectoryBox.Size = new System.Drawing.Size(143, 20);
			this.DirectoryBox.TabIndex = 8;
			// 
			// ArgumentsBox
			// 
			this.ArgumentsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ArgumentsBox.Location = new System.Drawing.Point(104, 106);
			this.ArgumentsBox.Multiline = true;
			this.ArgumentsBox.Name = "ArgumentsBox";
			this.ArgumentsBox.Size = new System.Drawing.Size(234, 81);
			this.ArgumentsBox.TabIndex = 7;
			// 
			// DirectoryButton
			// 
			this.DirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DirectoryButton.Enabled = false;
			this.DirectoryButton.Location = new System.Drawing.Point(253, 77);
			this.DirectoryButton.Name = "DirectoryButton";
			this.DirectoryButton.Size = new System.Drawing.Size(85, 23);
			this.DirectoryButton.TabIndex = 4;
			this.DirectoryButton.Text = "Browse";
			this.DirectoryButton.UseVisualStyleBackColor = true;
			this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
			// 
			// PathButton
			// 
			this.PathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PathButton.Location = new System.Drawing.Point(253, 48);
			this.PathButton.Name = "PathButton";
			this.PathButton.Size = new System.Drawing.Size(85, 23);
			this.PathButton.TabIndex = 3;
			this.PathButton.Text = "Browse";
			this.PathButton.UseVisualStyleBackColor = true;
			this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
			// 
			// PathBox
			// 
			this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PathBox.Location = new System.Drawing.Point(104, 50);
			this.PathBox.Name = "PathBox";
			this.PathBox.ReadOnly = true;
			this.PathBox.Size = new System.Drawing.Size(143, 20);
			this.PathBox.TabIndex = 2;
			// 
			// NameBox
			// 
			this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameBox.Location = new System.Drawing.Point(104, 21);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(143, 20);
			this.NameBox.TabIndex = 1;
			// 
			// AdvancedGroup
			// 
			this.AdvancedGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AdvancedGroup.Controls.Add(this.AffinityBox);
			this.AdvancedGroup.Controls.Add(this.PriorityBox);
			this.AdvancedGroup.Controls.Add(this.AffinityLabel);
			this.AdvancedGroup.Controls.Add(this.PriorityLabel);
			this.AdvancedGroup.Location = new System.Drawing.Point(12, 211);
			this.AdvancedGroup.Name = "AdvancedGroup";
			this.AdvancedGroup.Size = new System.Drawing.Size(344, 63);
			this.AdvancedGroup.TabIndex = 1;
			this.AdvancedGroup.TabStop = false;
			this.AdvancedGroup.Text = "Advanced Settings";
			// 
			// AffinityBox
			// 
			this.AffinityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AffinityBox.ColumnWidth = 10;
			this.AffinityBox.FormattingEnabled = true;
			this.AffinityBox.Location = new System.Drawing.Point(148, 36);
			this.AffinityBox.MultiColumn = true;
			this.AffinityBox.Name = "AffinityBox";
			this.AffinityBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.AffinityBox.Size = new System.Drawing.Size(190, 17);
			this.AffinityBox.TabIndex = 3;
			// 
			// PriorityBox
			// 
			this.PriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PriorityBox.FormattingEnabled = true;
			this.PriorityBox.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
			this.PriorityBox.Location = new System.Drawing.Point(6, 36);
			this.PriorityBox.Name = "PriorityBox";
			this.PriorityBox.Size = new System.Drawing.Size(136, 21);
			this.PriorityBox.TabIndex = 2;
			// 
			// AffinityLabel
			// 
			this.AffinityLabel.AutoSize = true;
			this.AffinityLabel.Location = new System.Drawing.Point(145, 20);
			this.AffinityLabel.Name = "AffinityLabel";
			this.AffinityLabel.Size = new System.Drawing.Size(79, 13);
			this.AffinityLabel.TabIndex = 1;
			this.AffinityLabel.Text = "Process Affinity";
			// 
			// PriorityLabel
			// 
			this.PriorityLabel.AutoSize = true;
			this.PriorityLabel.Location = new System.Drawing.Point(6, 20);
			this.PriorityLabel.Name = "PriorityLabel";
			this.PriorityLabel.Size = new System.Drawing.Size(79, 13);
			this.PriorityLabel.TabIndex = 0;
			this.PriorityLabel.Text = "Process Priority";
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveButton.Location = new System.Drawing.Point(12, 280);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 2;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteButton.Location = new System.Drawing.Point(93, 280);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 3;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Visible = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// SettingsCancelButton
			// 
			this.SettingsCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SettingsCancelButton.Location = new System.Drawing.Point(281, 280);
			this.SettingsCancelButton.Name = "SettingsCancelButton";
			this.SettingsCancelButton.Size = new System.Drawing.Size(75, 23);
			this.SettingsCancelButton.TabIndex = 4;
			this.SettingsCancelButton.Text = "Cancel";
			this.SettingsCancelButton.UseVisualStyleBackColor = true;
			this.SettingsCancelButton.Click += new System.EventHandler(this.SettingsCancelButton_Click);
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 315);
			this.Controls.Add(this.SettingsCancelButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.AdvancedGroup);
			this.Controls.Add(this.BasicGroup);
			this.MinimumSize = new System.Drawing.Size(384, 325);
			this.Name = "SettingsWindow";
			this.BasicGroup.ResumeLayout(false);
			this.BasicGroup.PerformLayout();
			this.AdvancedGroup.ResumeLayout(false);
			this.AdvancedGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox BasicGroup;
		private System.Windows.Forms.CheckBox AutoRestartBox;
		private System.Windows.Forms.Label DirectoryLabel;
		private System.Windows.Forms.Label ArgumentsLabel;
		private System.Windows.Forms.TextBox DirectoryBox;
		private System.Windows.Forms.TextBox ArgumentsBox;
		private System.Windows.Forms.Button PathButton;
		private System.Windows.Forms.TextBox PathBox;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.GroupBox AdvancedGroup;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label PathLabel;
		private System.Windows.Forms.Label PriorityLabel;
		private System.Windows.Forms.Label AffinityLabel;
		private System.Windows.Forms.ComboBox PriorityBox;
		private System.Windows.Forms.ListBox AffinityBox;
		private System.Windows.Forms.Button DirectoryButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button SettingsCancelButton;
	}
}