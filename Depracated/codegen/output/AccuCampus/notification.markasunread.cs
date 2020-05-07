using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Notifications.
	/// </summary>
	public static partial class Notification
	{
		
		/// <summary>
		/// Mark a notification as unread.  This action requires authentication.
		/// </summary>


		public static ActionResult Markasunread(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notification.markasunread", new {
});
		}

		
		/// <summary>
		/// Mark a notification as unread
		/// </summary>
		/// <param name="@id">The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.</param>
		/// <param name="@status">Specifies the status to filter the notifications. Read, Unread or All.</param>
		/// <param name="@startdate">The start date of the period to filter the notifications.</param>
		/// <param name="@enddate">The end date of the period to filter the notifications.</param>


		public static ActionResult Markasunread(Guid @id, NotificationStatus @status, DateTime @startdate, DateTime @enddate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notification.markasunread", new {@id, @status, @startdate, @enddate
});
		}

		

	}
}


