using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Send generated templates by email for a specific job..  This action requires authentication.
		/// </summary>
		/// <param name="@jobid">The id of the job that is creating the templates.</param>


		public static ActionResult Sendgenerated(string @jobid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.sendgenerated", new {@jobid
});
		}

		

	}
}


