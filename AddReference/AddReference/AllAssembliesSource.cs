namespace AddReference
{
	using System.Collections.Generic;
	using Microsoft.Win32;

	public class AllAssembliesSource:INetAssembliesSource
	{

		private const string ASSEMBLYFOLDERPATH = @"SOFTWARE\Microsoft\.NETFramework\AssemblyFolders";


		public AssemblyData[] GetAssemblyDatas()
		{
			var folders = new List<string>();
			this.AddFoldersFromAssemb(Registry.LocalMachine,folders);
			this.AddFoldersFromAssemb(Registry.CurrentUser,folders);
			var resultList = new List<AssemblyData>();
			foreach (var folder in folders)
			{
                if (!System.IO.Directory.Exists(folder))
                    continue;
				var folderAssemblySource = new FolderAssembliesSource(folder, true);
				resultList.AddRange(folderAssemblySource.GetAssemblyDatas());
			}
			return resultList.ToArray();
		}
		protected void AddFoldersFromAssemb(RegistryKey key,List<string> folders)
		{
			using (var subFolder = key.OpenSubKey(ASSEMBLYFOLDERPATH))
			{
				if(subFolder==null)
					return;
				var names = subFolder.GetSubKeyNames();
				foreach (var name in names)
				{
					using (var subkey = subFolder.OpenSubKey(name))
					{
						var path = subkey.GetValue(string.Empty) as string;
						if (string.IsNullOrEmpty(path))
							path = subkey.GetValue("All Assemblies In") as string;
						if (!string.IsNullOrEmpty(path) && !folders.Contains(path.ToLower()))
							folders.Add(path.ToLower());
					}
				}
			}
		}
	}
}
