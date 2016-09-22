using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Reports.
	/// </summary>
	public static partial class Report
	{
		
		/// <summary>
		/// Prepares an attendance analytics report.  This action requires authentication.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>


		public static ActionResult Attanalyticsprepare(string @reportname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "report.attanalyticsprepare", new {@reportname
});
		}

		
		/// <summary>
		/// Prepares an attendance analytics report
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@params">A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3</param>
		/// <param name="@refreshgroup">The ID of the group to check (and refresh) before processing the report.</param>


		public static ActionResult Attanalyticsprepare(string @reportname, string @params, Guid @refreshgroup
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "report.attanalyticsprepare", new {@reportname, @params, @refreshgroup
});
		}

		

	}
}


