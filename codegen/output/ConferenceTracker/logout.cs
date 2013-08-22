using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Logouts.
	/// </summary>
	public static partial class Logout
	{
		
		/// <summary>
		/// Logout.  This action requires authentication.
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "logout", new {
});
		}

		

	}
}


