using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Accountlinkss.
	/// </summary>
	public static partial class Accountlinks
	{
		
		/// <summary>
		/// Lists linked the accounts.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "accountlinks.list", new {
});
		}

		

	}
}


