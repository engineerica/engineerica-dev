using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Sessionsurveys.
	/// </summary>
	public static partial class Sessionsurvey
	{
		
		/// <summary>
		/// Gets all the information to do the surveys of the sessions the current user attended..  This action requires authentication.
		/// </summary>


		public static ActionResult Query(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "sessionsurvey.query", new {
});
		}

		

	}
}


