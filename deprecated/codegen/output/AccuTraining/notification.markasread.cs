using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Notifications.
	/// </summary>
	public static partial class Notification
	{
		
		/// <summary>
		/// Mark a notification as read.  This action requires authentication.
		/// </summary>


		public static ActionResult Markasread(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "notification.markasread", new {
});
		}

		
		/// <summary>
		/// Mark a notification as read
		/// </summary>
		/// <param name="@id">The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.</param>
		/// <param name="@status">Specifies the status to filter the notifications. Read, Unread or All.</param>
		/// <param name="@startdate">The start date of the period to filter the notifications.</param>
		/// <param name="@enddate">The end date of the period to filter the notifications.</param>


		public static ActionResult Markasread(Guid @id, NotificationStatus @status, DateTime @startdate, DateTime @enddate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "notification.markasread", new {@id, @status, @startdate, @enddate
});
		}

		

	}
}


