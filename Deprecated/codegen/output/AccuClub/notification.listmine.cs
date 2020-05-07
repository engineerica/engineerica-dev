using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Notifications.
	/// </summary>
	public static partial class Notification
	{
		
		/// <summary>
		/// View all the notifications sent to the logged user.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listmine(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "notification.listmine", new {@from, @count
});
		}

		
		/// <summary>
		/// View all the notifications sent to the logged user
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@status">Specifies the status of the notifications to list. Read, Unread or All.</param>
		/// <param name="@startdate">The start date of the period to filter the notifications.</param>
		/// <param name="@enddate">The end date of the period to filter the notifications.</param>


		public static ActionResult Listmine(int @from, int @count, NotificationStatus @status, DateTime @startdate, DateTime @enddate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "notification.listmine", new {@from, @count, @status, @startdate, @enddate
});
		}

		

	}
}


