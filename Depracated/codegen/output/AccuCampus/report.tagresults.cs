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
		/// Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users..  This action requires authentication.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@assign">Specify whether the specified tags have to be assigned or unassigned.</param>
		/// <param name="@tags">The tags to assign (or unassign) to the resulting users in the report, in JSON format.</param>


		public static ActionResult Tagresults(string @reportname, bool @assign, string @tags
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "report.tagresults", new {@reportname, @assign, @tags
});
		}

		
		/// <summary>
		/// Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
		/// </summary>
		/// <param name="@reportname">The name of the report to execute</param>
		/// <param name="@assign">Specify whether the specified tags have to be assigned or unassigned.</param>
		/// <param name="@tags">The tags to assign (or unassign) to the resulting users in the report, in JSON format.</param>
		/// <param name="@params">A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3</param>


		public static ActionResult Tagresults(string @reportname, bool @assign, string @tags, string @params
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "report.tagresults", new {@reportname, @assign, @tags, @params
});
		}

		

	}
}


