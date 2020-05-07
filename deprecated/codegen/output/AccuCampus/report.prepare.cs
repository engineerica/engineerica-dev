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
		/// Queries and loads the specified report, in background..  This action requires authentication.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>


		public static ActionResult Prepare(string @reportname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "report.prepare", new {@reportname
});
		}

		
		/// <summary>
		/// Queries and loads the specified report, in background.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@params">A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3</param>
		/// <param name="@repformat">The format of the resulting report. Json, pdf, csv, ...</param>
		/// <param name="@fillgroupid">If specified, the result is used to fill the group with the given ID</param>
		/// <param name="@groupby">How to group the records. In the format 'col1+col2|col3+col4</param>
		/// <param name="@refreshgroup">The ID of the group to check (and refresh) before processing the report.</param>
		/// <param name="@filtertext">The user friendly text of the applied filters.</param>


		public static ActionResult Prepare(string @reportname, string @params, string @repformat, Guid @fillgroupid, string @groupby, Guid @refreshgroup, string @filtertext
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "report.prepare", new {@reportname, @params, @repformat, @fillgroupid, @groupby, @refreshgroup, @filtertext
});
		}

		

	}
}


