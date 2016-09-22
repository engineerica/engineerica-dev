using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Notificationtopics.
	/// </summary>
	public static partial class Notificationtopic
	{
		
		/// <summary>
		/// List all the notification topics available to subscribe.  This action requires authentication.
		/// </summary>


		public static ActionResult Listsubscribe(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notificationtopic.listsubscribe", new {
});
		}

		

	}
}


