using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Reports.
	/// </summary>
	public static partial class Report
	{
		
		/// <summary>
		/// Lists available reports.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "report.list", new {
});
		}

		

	}
}


