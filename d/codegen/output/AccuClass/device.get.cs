using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Devices.
	/// </summary>
	public static partial class Device
	{
		
		/// <summary>
		/// Get device.  This action requires authentication.
		/// </summary>
		/// <param name="@device">The unique id of the device.</param>


		public static ActionResult Get(string @device
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "device.get", new {@device
});
		}

		
		/// <summary>
		/// Get device
		/// </summary>
		/// <param name="@device">The unique id of the device.</param>
		/// <param name="@devicename">The custom name of the device.</param>


		public static ActionResult Get(string @device, string @devicename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "device.get", new {@device, @devicename
});
		}

		

	}
}


