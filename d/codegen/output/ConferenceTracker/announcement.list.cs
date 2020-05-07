using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Announcements.
	/// </summary>
	public static partial class Announcement
	{
		
		/// <summary>
		/// Gets the announcements of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(string @from, string @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the announcements of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference for which the announcements have to be returned. If not specified the 'next' conference will be used.</param>


		public static ActionResult List(string @from, string @count, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.list", new {@from, @count, @conference
});
		}

		

	}
}


