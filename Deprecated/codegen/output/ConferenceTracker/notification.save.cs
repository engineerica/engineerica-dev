using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Notifications.
	/// </summary>
	public static partial class Notification
	{
		
		/// <summary>
		/// Saves a notification.  This action requires authentication.
		/// </summary>
		/// <param name="@foruserid">The ID of the user to wait for check-in</param>
		/// <param name="@onevent">Name of the event when to send the text message. Eg, 'checkin'</param>


		public static ActionResult Save(Guid @foruserid, string @onevent
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "notification.save", new {@foruserid, @onevent
});
		}

		
		/// <summary>
		/// Saves a notification
		/// </summary>
		/// <param name="@foruserid">The ID of the user to wait for check-in</param>
		/// <param name="@onevent">Name of the event when to send the text message. Eg, 'checkin'</param>
		/// <param name="@id">The id of the notification to save (leave empty to create a new one).</param>
		/// <param name="@conference">The id of the conference for which the notifications have to be returned. If not specified the 'next' conference will be used.</param>
		/// <param name="@notifyuserid">The ID to notify if different that the attendee</param>
		/// <param name="@notes">Text to send in the message</param>


		public static ActionResult Save(Guid @foruserid, string @onevent, Guid @id, string @conference, Guid @notifyuserid, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "notification.save", new {@foruserid, @onevent, @id, @conference, @notifyuserid, @notes
});
		}

		

	}
}


