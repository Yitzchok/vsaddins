﻿namespace AddReference
{
    using System.Linq;
    using GongSolutions.Shell;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class QuickReference : Form, IAssemblySelectionView
    {
        public QuickReference()
        {
            InitializeComponent();
            this.ptLocations.ShellView = this.shellView;
            this.shellView.FilterItem += shellView_FilterItem;
            shellView.Focus();
        }

        void shellView_FilterItem(object sender, FilterItemEventArgs e)
        {
            e.Include = ((e.Item.FileSystemPath.ToLowerInvariant().EndsWith(".dll") ||
                         e.Item.FileSystemPath.ToLowerInvariant().EndsWith("*.exe")) && !e.Item.IsFolder) || e.Item.IsFolder;
        }

        private DialogSelectionResult dialogSelectionResult;


        public void BindNetAssemblies(IEnumerable<AssemblyData> assemblyDatas)
        {
            lvAssemblies.BeginUpdate();
            this.lvAssemblies.SelectedItems.Clear();
            this.lvAssemblies.Items.Clear();
            foreach (var data in assemblyDatas)
            {
                var listViewItem = new ListViewItem(new[] { data.AssemblyName, data.Version, data.RuntimeVersion, data.Path });
                listViewItem.Tag = data;
                lvAssemblies.Items.Add(listViewItem);
            }
            lvAssemblies.EndUpdate();
        }
        public void BindProjects(IEnumerable<ProjectData> projectDatas)
        {
            lvProjects.BeginUpdate();
            this.lvProjects.Items.Clear();

            foreach (var data in projectDatas)
            {
                var listViewItem = new ListViewItem(new[] { data.Name, data.Path });
                listViewItem.Tag = data;
                lvProjects.Items.Add(listViewItem);
            }
            lvProjects.EndUpdate();
        }
        public void BindEntryFolder(string path)
        {
            this.shellView.Navigate(path);
        }
        public void ClearSelections()
        {
            this.tbReference.SelectedIndex = 0;
            this.lvProjects.SelectedItems.Clear();
            this.lvProjects.SelectedIndices.Clear();
            this.lvAssemblies.SelectedItems.Clear();
            this.lvAssemblies.SelectedIndices.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseAndStoreResult();
        }
        private void shellView_DoubleClick(object sender, EventArgs e)
        {
            this.CloseAndStoreResult();
        }
        private void lvAssemblies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.CloseAndStoreResult();
        }

        private void lvProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.CloseAndStoreResult();
        }

        private void CloseAndStoreResult()
        {
            this.DialogResult = DialogResult.OK;
            var result = new DialogSelectionResult();
            result.Assemblies = this.lvAssemblies.SelectedItems.Cast<ListViewItem>().Select(x => (AssemblyData)x.Tag).ToArray();
            result.Projects = this.lvProjects.SelectedItems.Cast<ListViewItem>().Select(x => (ProjectData)x.Tag).ToArray();
            result.BrowsePaths = this.shellView.SelectedItems.Cast<ShellItem>().Select(x => x.FileSystemPath).ToArray();
            this.dialogSelectionResult = result;
            this.Close();
        }

        private void QuickReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.HandleEscape(e);
            }
        }

        private void HandleEscape(KeyEventArgs e)
        {
            this.Close();
        }

        private void HandleBack(KeyEventArgs e)
        {
            if (this.shellView.CanNavigateParent)
                this.shellView.NavigateParent();
        }

        #region IAssemblySelectionView Members

        public DialogSelectionResult DialogSelectionResult
        {
            get { return this.dialogSelectionResult; }
        }

        #endregion

        private void cbFilePath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                shellView.Navigate(cbFilePath.Text);
            }
        }

        private void shellView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.HandleBack(e);
            }
        }
    }
}
