using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Devices.
	/// </summary>
	public static partial class Device
	{
		
		/// <summary>
		/// Saves a device.  This action requires authentication.
		/// </summary>
		/// <param name="@deviceid">The id of the device to save.</param>
		/// <param name="@name">The name of the device.</param>


		public static ActionResult Save(Guid @deviceid, string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "device.save", new {@deviceid, @name
});
		}

		
		/// <summary>
		/// Saves a device
		/// </summary>
		/// <param name="@deviceid">The id of the device to save.</param>
		/// <param name="@name">The name of the device.</param>
		/// <param name="@pushtoken">The push token of the device.</param>


		public static ActionResult Save(Guid @deviceid, string @name, string @pushtoken
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "device.save", new {@deviceid, @name, @pushtoken
});
		}

		

	}
}


