namespace AddReference
{
	using System.Threading;
	using System;
	using Extensibility;
	using EnvDTE;
	using EnvDTE80;
	using Microsoft.VisualStudio.CommandBars;

	/// <summary>The object for implementing an Add-in.</summary>
	/// <seealso class='IDTExtensibility2' />
	public class Connect : IDTExtensibility2
	{
		private DTE2 applicationObject;
		private AddIn addInInstance;
		private CommandBarButton button;
		private QuickReference quickReferenceForm;
		private AssemblySelectionPresenter presenter;
		private CommandBarPopup referenceRoots;




		public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
		{
			applicationObject = (DTE2)application;
			addInInstance = (AddIn)addInInst;
			CommandBars cb = applicationObject.CommandBars as CommandBars;
			CommandBar bar = cb["Context Menus"];
			CommandBarPopup cbarControl = bar.Controls["Project and Solution Context Menus"] as CommandBarPopup;
			var commandBarControls = cbarControl.Controls;
			this.referenceRoots = commandBarControls["Reference Root"] as CommandBarPopup;

			AddAddReferenceContextMenuItem();
			this.quickReferenceForm = new QuickReference();
			var uiContext = SynchronizationContext.Current;
			this.presenter = new AssemblySelectionPresenter(this.applicationObject, this.quickReferenceForm, uiContext);
		}
		public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
		{
			this.RemoveAddReferenceContextMenuItem();
		}
		public void OnAddInsUpdate(ref Array custom)
		{
		}
		public void OnStartupComplete(ref Array custom)
		{
		}
		public void OnBeginShutdown(ref Array custom)
		{
		}
		

		private void AddAddReferenceContextMenuItem()
		{

			button = this.referenceRoots.Controls.Add(MsoControlType.msoControlButton,
			                           System.Reflection.Missing.Value,
			                           System.Reflection.Missing.Value, 1, true) as CommandBarButton;
			button.Caption = "Add Quick Reference";
			button.Click += oControl_Click;
		}
		private void RemoveAddReferenceContextMenuItem()
		{
			button.Delete(false);
			button = null;
		}

		void oControl_Click(CommandBarButton Ctrl, ref bool CancelDefault)
		{
			presenter.Start();
		}
	}
}