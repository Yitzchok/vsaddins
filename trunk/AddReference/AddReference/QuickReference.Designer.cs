namespace AddReference
{
	partial class QuickReference
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
            this.sptReferenceButton = new System.Windows.Forms.SplitContainer();
            this.tbReference = new System.Windows.Forms.TabControl();
            this.tbBrowse = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ptLocations = new GongSolutions.Shell.PlacesToolbar();
            this.scFolderPath = new System.Windows.Forms.SplitContainer();
            this.fdFolderPath = new GongSolutions.Shell.FileDialogToolbar();
            this.shellView = new GongSolutions.Shell.ShellView();
            this.tbNET = new System.Windows.Forms.TabPage();
            this.lvAssemblies = new System.Windows.Forms.ListView();
            this.chAssemblyName = new System.Windows.Forms.ColumnHeader();
            this.chVersion = new System.Windows.Forms.ColumnHeader();
            this.chRuntime = new System.Windows.Forms.ColumnHeader();
            this.chPath = new System.Windows.Forms.ColumnHeader();
            this.tbProject = new System.Windows.Forms.TabPage();
            this.lvProjects = new System.Windows.Forms.ListView();
            this.chProjectName = new System.Windows.Forms.ColumnHeader();
            this.chProjectPath = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.sptReferenceButton.Panel1.SuspendLayout();
            this.sptReferenceButton.Panel2.SuspendLayout();
            this.sptReferenceButton.SuspendLayout();
            this.tbReference.SuspendLayout();
            this.tbBrowse.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.scFolderPath.Panel1.SuspendLayout();
            this.scFolderPath.Panel2.SuspendLayout();
            this.scFolderPath.SuspendLayout();
            this.tbNET.SuspendLayout();
            this.tbProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // sptReferenceButton
            // 
            this.sptReferenceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptReferenceButton.Location = new System.Drawing.Point(0, 0);
            this.sptReferenceButton.Name = "sptReferenceButton";
            this.sptReferenceButton.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptReferenceButton.Panel1
            // 
            this.sptReferenceButton.Panel1.Controls.Add(this.tbReference);
            // 
            // sptReferenceButton.Panel2
            // 
            this.sptReferenceButton.Panel2.Controls.Add(this.button1);
            this.sptReferenceButton.Size = new System.Drawing.Size(718, 405);
            this.sptReferenceButton.SplitterDistance = 357;
            this.sptReferenceButton.TabIndex = 0;
            // 
            // tbReference
            // 
            this.tbReference.Controls.Add(this.tbBrowse);
            this.tbReference.Controls.Add(this.tbNET);
            this.tbReference.Controls.Add(this.tbProject);
            this.tbReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReference.Location = new System.Drawing.Point(0, 0);
            this.tbReference.Name = "tbReference";
            this.tbReference.SelectedIndex = 0;
            this.tbReference.Size = new System.Drawing.Size(718, 357);
            this.tbReference.TabIndex = 0;
            // 
            // tbBrowse
            // 
            this.tbBrowse.Controls.Add(this.splitContainer1);
            this.tbBrowse.Location = new System.Drawing.Point(4, 22);
            this.tbBrowse.Name = "tbBrowse";
            this.tbBrowse.Padding = new System.Windows.Forms.Padding(3);
            this.tbBrowse.Size = new System.Drawing.Size(710, 331);
            this.tbBrowse.TabIndex = 0;
            this.tbBrowse.Text = "Browse";
            this.tbBrowse.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ptLocations);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scFolderPath);
            this.splitContainer1.Size = new System.Drawing.Size(704, 325);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // ptLocations
            // 
            this.ptLocations.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptLocations.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptLocations.Location = new System.Drawing.Point(0, 0);
            this.ptLocations.Name = "ptLocations";
            this.ptLocations.Size = new System.Drawing.Size(130, 325);
            this.ptLocations.TabIndex = 0;
            // 
            // scFolderPath
            // 
            this.scFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFolderPath.Location = new System.Drawing.Point(0, 0);
            this.scFolderPath.Name = "scFolderPath";
            this.scFolderPath.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scFolderPath.Panel1
            // 
            this.scFolderPath.Panel1.Controls.Add(this.fdFolderPath);
            // 
            // scFolderPath.Panel2
            // 
            this.scFolderPath.Panel2.Controls.Add(this.shellView);
            this.scFolderPath.Size = new System.Drawing.Size(570, 325);
            this.scFolderPath.SplitterDistance = 28;
            this.scFolderPath.TabIndex = 0;
            // 
            // fdFolderPath
            // 
            this.fdFolderPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.fdFolderPath.Location = new System.Drawing.Point(0, 0);
            this.fdFolderPath.Name = "fdFolderPath";
            this.fdFolderPath.ShellView = this.shellView;
            this.fdFolderPath.Size = new System.Drawing.Size(570, 28);
            this.fdFolderPath.TabIndex = 0;
            // 
            // shellView
            // 
            this.shellView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellView.Location = new System.Drawing.Point(0, 0);
            this.shellView.Name = "shellView";
            this.shellView.Size = new System.Drawing.Size(570, 293);
            this.shellView.StatusBar = null;
            this.shellView.TabIndex = 0;
            this.shellView.Text = "shellView";
            this.shellView.View = GongSolutions.Shell.ShellViewStyle.Details;
            this.shellView.DoubleClick += new System.EventHandler(this.shellView_DoubleClick);
            // 
            // tbNET
            // 
            this.tbNET.Controls.Add(this.lvAssemblies);
            this.tbNET.Location = new System.Drawing.Point(4, 22);
            this.tbNET.Name = "tbNET";
            this.tbNET.Padding = new System.Windows.Forms.Padding(3);
            this.tbNET.Size = new System.Drawing.Size(710, 331);
            this.tbNET.TabIndex = 1;
            this.tbNET.Text = ".NET";
            this.tbNET.UseVisualStyleBackColor = true;
            // 
            // lvAssemblies
            // 
            this.lvAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAssemblyName,
            this.chVersion,
            this.chRuntime,
            this.chPath});
            this.lvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAssemblies.FullRowSelect = true;
            this.lvAssemblies.GridLines = true;
            this.lvAssemblies.HideSelection = false;
            this.lvAssemblies.Location = new System.Drawing.Point(3, 3);
            this.lvAssemblies.Name = "lvAssemblies";
            this.lvAssemblies.ShowGroups = false;
            this.lvAssemblies.Size = new System.Drawing.Size(704, 325);
            this.lvAssemblies.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAssemblies.TabIndex = 1;
            this.lvAssemblies.UseCompatibleStateImageBehavior = false;
            this.lvAssemblies.View = System.Windows.Forms.View.Details;
            this.lvAssemblies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAssemblies_MouseDoubleClick);
            // 
            // chAssemblyName
            // 
            this.chAssemblyName.Text = "Assembly";
            this.chAssemblyName.Width = 200;
            // 
            // chVersion
            // 
            this.chVersion.Text = "Version";
            this.chVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chVersion.Width = 97;
            // 
            // chRuntime
            // 
            this.chRuntime.Text = "Runtime";
            this.chRuntime.Width = 85;
            // 
            // chPath
            // 
            this.chPath.Text = "Path";
            this.chPath.Width = 305;
            // 
            // tbProject
            // 
            this.tbProject.Controls.Add(this.lvProjects);
            this.tbProject.Location = new System.Drawing.Point(4, 22);
            this.tbProject.Name = "tbProject";
            this.tbProject.Padding = new System.Windows.Forms.Padding(3);
            this.tbProject.Size = new System.Drawing.Size(710, 331);
            this.tbProject.TabIndex = 2;
            this.tbProject.Text = "Projects";
            this.tbProject.UseVisualStyleBackColor = true;
            // 
            // lvProjects
            // 
            this.lvProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProjectName,
            this.chProjectPath});
            this.lvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProjects.FullRowSelect = true;
            this.lvProjects.HideSelection = false;
            this.lvProjects.Location = new System.Drawing.Point(3, 3);
            this.lvProjects.Name = "lvProjects";
            this.lvProjects.ShowGroups = false;
            this.lvProjects.Size = new System.Drawing.Size(704, 325);
            this.lvProjects.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvProjects.TabIndex = 0;
            this.lvProjects.UseCompatibleStateImageBehavior = false;
            this.lvProjects.View = System.Windows.Forms.View.Details;
            this.lvProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProjects_MouseDoubleClick);
            // 
            // chProjectName
            // 
            this.chProjectName.Text = "Name";
            this.chProjectName.Width = 180;
            // 
            // chProjectPath
            // 
            this.chProjectPath.Text = "Path";
            this.chProjectPath.Width = 421;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(643, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuickReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.sptReferenceButton);
            this.KeyPreview = true;
            this.Name = "QuickReference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Reference";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuickReference_KeyDown);
            this.sptReferenceButton.Panel1.ResumeLayout(false);
            this.sptReferenceButton.Panel2.ResumeLayout(false);
            this.sptReferenceButton.ResumeLayout(false);
            this.tbReference.ResumeLayout(false);
            this.tbBrowse.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.scFolderPath.Panel1.ResumeLayout(false);
            this.scFolderPath.Panel2.ResumeLayout(false);
            this.scFolderPath.ResumeLayout(false);
            this.tbNET.ResumeLayout(false);
            this.tbProject.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer sptReferenceButton;
		private System.Windows.Forms.TabControl tbReference;
		private System.Windows.Forms.TabPage tbBrowse;
		private System.Windows.Forms.TabPage tbNET;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private GongSolutions.Shell.PlacesToolbar ptLocations;
		private GongSolutions.Shell.ShellView shellView;
		private System.Windows.Forms.ListView lvAssemblies;
		private System.Windows.Forms.ColumnHeader chAssemblyName;
		private System.Windows.Forms.ColumnHeader chVersion;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ColumnHeader chRuntime;
		private System.Windows.Forms.ColumnHeader chPath;
		private System.Windows.Forms.SplitContainer scFolderPath;
		private GongSolutions.Shell.FileDialogToolbar fdFolderPath;
		private System.Windows.Forms.TabPage tbProject;
		private System.Windows.Forms.ListView lvProjects;
		private System.Windows.Forms.ColumnHeader chProjectName;
		private System.Windows.Forms.ColumnHeader chProjectPath;
	}
}