namespace AddReference
{
	using System.IO;

	public class FolderAssembliesSource:AssembliesSourceBase
	{
		private readonly string folderName;
		private readonly bool subdirectories;

		public FolderAssembliesSource(string folderName,bool subdirectories)
		{
			this.folderName = folderName;
			this.subdirectories = subdirectories;
		}

		protected override string[] GetAssemblies()
		{
			return Directory.GetFiles(folderName, "*.dll",
			                          subdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
		}
	}
}
