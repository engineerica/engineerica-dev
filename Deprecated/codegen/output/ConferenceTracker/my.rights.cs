using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Returns the list of actions that the user can execute..  This action requires authentication.
		/// </summary>


		public static ActionResult Rights(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "my.rights", new {
});
		}

		

	}
}


