using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports the account data.  This action requires authentication.
		/// </summary>
		/// <param name="@exporttype">What to export.</param>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public static ActionResult Execute(string @exporttype, string @exportformat
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "export", new {@exporttype, @exportformat
});
		}

		
		/// <summary>
		/// Exports the account data
		/// </summary>
		/// <param name="@exporttype">What to export.</param>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>
		/// <param name="@filters">Pipe separated filters for the export, eg: aaa=val|bbb=val|...</param>


		public static ActionResult Execute(string @exporttype, string @exportformat, string @filters
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "export", new {@exporttype, @exportformat, @filters
});
		}

		

	}
}


