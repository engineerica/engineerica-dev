using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Summary report of the registrations.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference whose registrations are to be retrieved.</param>


		public static ActionResult Summaryreport(int @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.summaryreport", new {@conference
});
		}

		

	}
}


