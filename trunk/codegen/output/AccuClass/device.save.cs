using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Devices.
	/// </summary>
	public partial class Device : ActionSet
	{
		
		/// <summary>
		/// Saves a device.  This action requires authentication.
		/// </summary>
		/// <param name="_deviceId">The id of the device to save.</param>
		/// <param name="_name">The name of the device.</param>


		public ActionResult Save(Guid _deviceId, string _name
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "device.save", new {_deviceId, _name
});
		}

		

	}
}


