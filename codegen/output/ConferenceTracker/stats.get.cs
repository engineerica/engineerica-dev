using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Statss.
	/// </summary>
	public static partial class Stats
	{
		
		/// <summary>
		/// Gets the stats for the current account..  This action requires authentication.
		/// </summary>


		public static ActionResult Get(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "stats.get", new {
});
		}

		

	}
}


