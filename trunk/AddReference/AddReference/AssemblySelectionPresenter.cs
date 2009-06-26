namespace AddReference
{
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;
	using System;
	using System.Collections.Generic;
	using System.IO;
	using EnvDTE;
	using EnvDTE80;
	using VSLangProj;

	public class AssemblySelectionPresenter
	{
		private readonly DTE2 applicationObject;
		private readonly IAssemblySelectionView selectionView;
		private INetAssembliesSource allAssembliesSource;
		private SynchronizationContext uiContext;
		public AssemblySelectionPresenter(DTE2 applicationObject, IAssemblySelectionView selectionView,SynchronizationContext uiContext)
		{
			this.uiContext = uiContext;
			this.applicationObject = applicationObject;
			this.selectionView = selectionView;
			this.allAssembliesSource = new CachedAssembliesSource(new AllAssembliesSource());
		}

		public void Start()
		{
			this.selectionView.ClearSelections();
			string fullPath = this.GetActiveProject().Project.FullName;
			var directory = Path.GetDirectoryName(fullPath);
			this.selectionView.BindEntryFolder(directory);
			ThreadPool.QueueUserWorkItem((x) => this.FillDataToView());

			var result = this.selectionView.ShowDialog();
			if (result != DialogResult.OK)
				return;
			var selectionResult = this.selectionView.DialogSelectionResult;
			var activeProject = GetActiveProject();
			foreach (var file in selectionResult.Assemblies)
				activeProject.References.Add(file.Path);
			foreach (var file in selectionResult.BrowsePaths)
				activeProject.References.Add(file);
			foreach (var proj in selectionResult.Projects)
				activeProject.References.AddProject(proj.Project);

		}
		private void FillDataToView()
		{
			var projectData = this.GetProjects();
			this.uiContext.Post((x) => this.selectionView.BindProjects(projectData), null);
			var assemblyData=this.GetAssemblyData();
			this.uiContext.Post((x)=>this.selectionView.BindNetAssemblies(assemblyData),null);
		}

		private IList<AssemblyData> GetAssemblyData()
		{
			var assemblies = this.allAssembliesSource.GetAssemblyDatas();
			return new List<AssemblyData>(assemblies);
		}
		private IEnumerable<ProjectData> GetProjects()
		{
			var activeProjects = this.GetOpenProjects();
			var list = new List<ProjectData>();
			foreach (var project in activeProjects)
			{
				if (project == null)
					continue;
				list.Add(new ProjectData { Project = project.Project });
			}
			return list;
		}
		private VSProject[] GetOpenProjects()
		{
			var projects = ListProjects(this.applicationObject);
			return projects.Select(x => x.Object).Cast<VSProject>().ToArray();
		}


		public static IEnumerable<Project> ListProjects(DTE2 applicationObject)
		{
			return PullProjectsFromAndRecurse(applicationObject.Solution.Projects.Cast<Project>())
				.OrderBy(p => p.Name);
		}



		private static IEnumerable<Project> PullProjectsFromAndRecurse(IEnumerable<Project> projects)
		{
			foreach (Project project in projects)
			{
				if (project.CodeModel != null)
				{
					yield return project;
				}
				else
				{
					var projectItems = project.ProjectItems.Cast<ProjectItem>();
					var subProjects = projectItems.Where(item => item.SubProject != null)
						.Select(item => item.SubProject);
					foreach (var subProject in PullProjectsFromAndRecurse(subProjects))
					{
						yield return subProject;
					}
				}
			}
		}

		private VSProject GetActiveProject()
		{
			Array array = (Array)this.applicationObject.ActiveSolutionProjects;
			if (array.Length > 0)
			{
				Project project = (Project)array.GetValue(0);
				return (VSProject)project.Object;
			}
			return null;
		}
	}
}