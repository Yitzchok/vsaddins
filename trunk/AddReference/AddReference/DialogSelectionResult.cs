using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddReference
{
	public class DialogSelectionResult
	{
		public string[] BrowsePaths { get; set; }
		public AssemblyData[] Assemblies { get; set; }
		public ProjectData[] Projects { get; set; }
	}
}
