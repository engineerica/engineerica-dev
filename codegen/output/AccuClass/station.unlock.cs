using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public static partial class Station
	{
		
		/// <summary>
		/// Unlocks the sign-in station.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to unlock.</param>
		/// <param name="@passcode">The passcode to unlock the station.</param>
		/// <param name="@method">The authentication method. Valid values are 'token' and 'cookie'.</param>


		public static ActionResult Unlock(Guid @id, string @passcode, string @method
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "station.unlock", new {@id, @passcode, @method
});
		}

		

	}
}


