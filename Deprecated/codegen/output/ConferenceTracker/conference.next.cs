using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Conferences.
	/// </summary>
	public static partial class Conference
	{
		
		/// <summary>
		/// Gets the next conference, or the current one if there's one.  This action requires authentication.
		/// </summary>


		public static ActionResult Next(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "conference.next", new {
});
		}

		
		/// <summary>
		/// Gets the next conference, or the current one if there's one
		/// </summary>
		/// <param name="@domain">The account's domain.</param>


		public static ActionResult Next(string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "conference.next", new {@domain
});
		}

		

	}
}


