using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Listtimezoness.
	/// </summary>
	public static partial class Listtimezones
	{
		
		/// <summary>
		/// Lists the available timezones
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, false, "listtimezones", new {
});
		}

		

	}
}


