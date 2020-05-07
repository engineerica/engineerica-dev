using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Reports.
	/// </summary>
	public static partial class Report
	{
		
		/// <summary>
		/// Queries and loads the specified report..  This action requires authentication.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>


		public static ActionResult Createexcel(string @reportname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "report.createexcel", new {@reportname
});
		}

		
		/// <summary>
		/// Queries and loads the specified report.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@groupbyfield">Group by custom field, number, 1-5</param>


		public static ActionResult Createexcel(string @reportname, int @groupbyfield
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "report.createexcel", new {@reportname, @groupbyfield
});
		}

		

	}
}


