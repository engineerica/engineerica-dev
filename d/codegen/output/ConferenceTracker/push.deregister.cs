using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Pushs.
	/// </summary>
	public static partial class Push
	{
		
		/// <summary>
		/// Deregisters the current device to receive push notifications
		/// </summary>
		/// <param name="@devicetoken">The device token where to send the notification.</param>
		/// <param name="@platform">Either ios or android</param>


		public static ActionResult Deregister(string @devicetoken, string @platform
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, false, "push.deregister", new {@devicetoken, @platform
});
		}

		

	}
}


