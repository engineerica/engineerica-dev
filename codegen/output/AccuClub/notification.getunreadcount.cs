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
		/// Get the number of unread notifications.  This action requires authentication.
		/// </summary>


		public static ActionResult Getunreadcount(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "notification.getunreadcount", new {
});
		}

		

	}
}


