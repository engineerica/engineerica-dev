using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Notifications.
	/// </summary>
	public static partial class Notification
	{
		
		/// <summary>
		/// Gets the notifications of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(string @from, string @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "notification.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the notifications of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference for which the notifications have to be returned. If not specified the 'next' conference will be used.</param>


		public static ActionResult List(string @from, string @count, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "notification.list", new {@from, @count, @conference
});
		}

		

	}
}


