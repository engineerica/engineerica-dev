using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Devices.
	/// </summary>
	public static partial class Device
	{
		
		/// <summary>
		/// Gets the devices of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "device.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the devices of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@session">The ID of the session to filter devices used there.</param>


		public static ActionResult List(int @from, int @count, Guid @session
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "device.list", new {@from, @count, @session
});
		}

		

	}
}


