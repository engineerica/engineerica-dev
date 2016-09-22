using System;
using EngineericaApi.ExtensionFiles.AccuClass;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports your data saved in the system..  This action requires authentication.
		/// </summary>
		/// <param name="@exporttype">The kind of data that you want to download.</param>


		public static ActionResult Execute(ExportType @exporttype
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "export", new {@exporttype
});
		}

		
		/// <summary>
		/// Exports your data saved in the system.
		/// </summary>
		/// <param name="@exporttype">The kind of data that you want to download.</param>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>
		/// <param name="@args">The comma separated args for the report.  For example studentid=XXX,semesterid=YYY.</param>


		public static ActionResult Execute(ExportType @exporttype, string @exportformat, string @args
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "export", new {@exporttype, @exportformat, @args
});
		}

		

	}
}


