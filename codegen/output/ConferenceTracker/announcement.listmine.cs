using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Announcements.
	/// </summary>
	public static partial class Announcement
	{
		
		/// <summary>
		/// Gets the announcements for me.  This action requires authentication.
		/// </summary>


		public static ActionResult Listmine(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.listmine", new {
});
		}

		
		/// <summary>
		/// Gets the announcements for me
		/// </summary>
		/// <param name="@conference">The id of the conference for which the announcements have to be returned. If not specified the 'next' conference will be used.</param>


		public static ActionResult Listmine(string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.listmine", new {@conference
});
		}

		

	}
}


