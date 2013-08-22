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
		/// <param name="@deviceId">The id of the device to save.</param>
		/// <param name="@name">The name of the device.</param>


		public static ActionResult Save(Guid @deviceId, string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "device.save", new {@deviceId, @name
});
		}

		

	}
}


