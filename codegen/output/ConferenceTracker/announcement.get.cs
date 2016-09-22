using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Announcements.
	/// </summary>
	public static partial class Announcement
	{
		
		/// <summary>
		/// Gets the announcement by id of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the announcement to be returned.</param>


		public static ActionResult Get(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.get", new {@id
});
		}

		

	}
}


