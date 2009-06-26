namespace AddReference
{
	using System;
	using System.Collections.Generic;

	public abstract class AssembliesSourceBase:INetAssembliesSource
	{
		public virtual AssemblyData[] GetAssemblyDatas()
		{
			var assemblies = this.GetAssemblies();
			var list = new List<AssemblyData>(assemblies.Length);
			foreach (var path in assemblies)
			{
				try
				{
					var assemblyData = AssemblyHelper.GetAssemblyData(path);
					list.Add(assemblyData);
				}
				catch (Exception)
				{

				}

			}
			return list.ToArray();
		}

		protected abstract string[] GetAssemblies();
	}
}
