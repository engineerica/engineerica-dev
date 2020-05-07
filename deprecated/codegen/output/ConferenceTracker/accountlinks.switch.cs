using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Accountlinkss.
	/// </summary>
	public static partial class Accountlinks
	{
		
		/// <summary>
		/// Switches the current auth token to another account.  This action requires authentication.
		/// </summary>
		/// <param name="@accountid">The ID of the account to switch.</param>


		public static ActionResult Switch(Guid @accountid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "accountlinks.switch", new {@accountid
});
		}

		

	}
}


