using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Enables newsletters on this account.  This action requires authentication.
		/// </summary>


		public static ActionResult Enable(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.enable", new {
});
		}

		

	}
}


