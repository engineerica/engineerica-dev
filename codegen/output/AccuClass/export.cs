using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public partial class Export : ActionSet
	{
		
		/// <summary>
		/// Exports your data saved in the system..  This action requires authentication.
		/// </summary>
		/// <param name="_exporttype">The kind of data that you want to download.</param>


		public ActionResult Execute(ExportType _exporttype
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "export", new {_exporttype
});
		}

		
		/// <summary>
		/// Exports your data saved in the system.
		/// </summary>
		/// <param name="_exporttype">The kind of data that you want to download.</param>
		/// <param name="_exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public ActionResult Execute(ExportType _exporttype, string _exportformat
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "export", new {_exporttype, _exportformat
});
		}

		

	}
}


