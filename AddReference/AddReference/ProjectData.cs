
namespace AddReference
{
	using EnvDTE;

	public class ProjectData
	{
		public string Name { get{ return this.Project.Name;} }
		public string Path { get { return this.Project.FullName; } }
		public Project Project { get; set; }
	}
}
