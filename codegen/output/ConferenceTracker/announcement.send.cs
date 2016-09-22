using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Announcements.
	/// </summary>
	public static partial class Announcement
	{
		
		/// <summary>
		/// Saves a announcement.  This action requires authentication.
		/// </summary>
		/// <param name="@title">Title of the announcement</param>
		/// <param name="@target">Either 'everyone', 'attendee' or 'session'.</param>


		public static ActionResult Send(string @title, string @target
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.send", new {@title, @target
});
		}

		
		/// <summary>
		/// Saves a announcement
		/// </summary>
		/// <param name="@title">Title of the announcement</param>
		/// <param name="@target">Either 'everyone', 'attendee' or 'session'.</param>
		/// <param name="@conference">The id of the conference for which the announcements have to be sent. If not specified the 'next' conference will be used.</param>
		/// <param name="@text">Full text of the announcement</param>
		/// <param name="@targetarg">If target is set to other than </param>


		public static ActionResult Send(string @title, string @target, string @conference, string @text, string @targetarg
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "announcement.send", new {@title, @target, @conference, @text, @targetarg
});
		}

		

	}
}


