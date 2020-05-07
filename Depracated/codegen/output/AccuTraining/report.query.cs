using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
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


		public static ActionResult Query(string @reportname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "report.query", new {@reportname
});
		}

		
		/// <summary>
		/// Queries and loads the specified report.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@params">A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3</param>


		public static ActionResult Query(string @reportname, string @params
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "report.query", new {@reportname, @params
});
		}

		

	}
}


