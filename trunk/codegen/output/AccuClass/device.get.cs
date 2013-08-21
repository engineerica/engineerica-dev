using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Devices.
	/// </summary>
	public partial class Device : ActionSet
	{
		
		/// <summary>
		/// Get device.  This action requires authentication.
		/// </summary>
		/// <param name="_device">The unique id of the device.</param>


		public ActionResult Get(string _device
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "device.get", new {_device
});
		}

		
		/// <summary>
		/// Get device
		/// </summary>
		/// <param name="_device">The unique id of the device.</param>
		/// <param name="_devicename">The custom name of the device.</param>


		public ActionResult Get(string _device, string _devicename
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "device.get", new {_device, _devicename
});
		}

		

	}
}


