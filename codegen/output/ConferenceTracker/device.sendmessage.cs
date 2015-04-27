using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Devices.
	/// </summary>
	public static partial class Device
	{
		
		/// <summary>
		/// Send a message to a device.  This action requires authentication.
		/// </summary>
		/// <param name="@uniquedeviceid">The unique id of the device.</param>
		/// <param name="@message">The body of the message to send.</param>


		public static ActionResult Sendmessage(Guid @uniquedeviceid, string @message
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "device.sendmessage", new {@uniquedeviceid, @message
});
		}

		

	}
}


