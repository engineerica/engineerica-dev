using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Sessionsurveys.
	/// </summary>
	public static partial class Sessionsurvey
	{
		
		/// <summary>
		/// Gets or sets whether the session surveys are enabled..  This action requires authentication.
		/// </summary>


		public static ActionResult Getoptions(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "sessionsurvey.getoptions", new {
});
		}

		

	}
}


