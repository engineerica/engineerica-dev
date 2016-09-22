using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Queries and loads the specified leads report..  This action requires authentication.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>


		public static ActionResult Reportquery(string @reportname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.reportquery", new {@reportname
});
		}

		
		/// <summary>
		/// Queries and loads the specified leads report.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@params">A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3</param>


		public static ActionResult Reportquery(string @reportname, string @params
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.reportquery", new {@reportname, @params
});
		}

		

	}
}


