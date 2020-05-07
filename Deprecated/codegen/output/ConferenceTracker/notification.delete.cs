using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Notifications.
	/// </summary>
	public static partial class Notification
	{
		
		/// <summary>
		/// Deletes a notification.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the notification to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "notification.delete", new {@id
});
		}

		

	}
}


