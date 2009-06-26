namespace AddReference
{
	using System.Collections.Generic;
	using System.Windows.Forms;

	public interface IAssemblySelectionView
	{
		DialogSelectionResult DialogSelectionResult { get; }
		DialogResult ShowDialog();
		void BindNetAssemblies(IEnumerable<AssemblyData> assemblyDatas);
		void BindProjects(IEnumerable<ProjectData> projectDatas);
		void BindEntryFolder(string path);
		void ClearSelections();
	}
}
