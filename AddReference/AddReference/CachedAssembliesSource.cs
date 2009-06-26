namespace AddReference
{
	public class CachedAssembliesSource:INetAssembliesSource
	{
		private readonly INetAssembliesSource source;
		private AssemblyData[] cachedResult;
		public CachedAssembliesSource(INetAssembliesSource source)
		{
			this.source = source;
		}

		public AssemblyData[] GetAssemblyDatas()
		{
			if (this.cachedResult == null)
				this.cachedResult = source.GetAssemblyDatas();
			return this.cachedResult;
		}
	}
}
