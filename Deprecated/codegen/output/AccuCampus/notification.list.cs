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
		/// View all the notifications.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notification.list", new {@from, @count
});
		}

		
		/// <summary>
		/// View all the notifications
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@recipient">The recipient whose notifications have to be listed.</param>
		/// <param name="@status">The status of the notifications to list. Read, Unread or All.</param>
		/// <param name="@startdate">The start date of the period to filter the notifications.</param>
		/// <param name="@enddate">The end date of the period to filter the notifications.</param>
		/// <param name="@sentonscreen">Specifies whether to list the notifications that were sent on-screen or not.</param>
		/// <param name="@sentemail">Specifies whether to list the notifications that were sent via e-mail or not.</param>
		/// <param name="@sentsms">Specifies whether to list the notifications that were sent via sms or not.</param>


		public static ActionResult List(int @from, int @count, Guid @recipient, NotificationStatus @status, DateTime @startdate, DateTime @enddate, bool @sentonscreen, bool @sentemail, bool @sentsms
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notification.list", new {@from, @count, @recipient, @status, @startdate, @enddate, @sentonscreen, @sentemail, @sentsms
});
		}

		

	}
}


