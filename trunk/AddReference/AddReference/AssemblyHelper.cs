namespace AddReference
{
	using System.Reflection;

	public static class AssemblyHelper
	{
		public static AssemblyData GetAssemblyData(string path)
		{
			var assembly = Assembly.ReflectionOnlyLoadFrom(path);
			return new AssemblyData
			       	{
			       		AssemblyName = assembly.GetName().Name,
			       		Path = path,
			       		Version = assembly.GetName().Version.ToString(),
			       		RuntimeVersion = assembly.ImageRuntimeVersion
			       	};

		}
	}
}
