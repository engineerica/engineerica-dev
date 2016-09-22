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
		/// Send on-screen notifications.  This action requires authentication.
		/// </summary>
		/// <param name="@notification">The ID of the notification to send.</param>


		public static ActionResult Sendonscreen(Guid @notification
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notification.sendonscreen", new {@notification
});
		}

		

	}
}


