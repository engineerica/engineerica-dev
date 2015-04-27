using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public static partial class Station
	{
		
		/// <summary>
		/// Gets the current license information
		/// </summary>
		/// <param name="@station">The id of the sign-in station whose account's license has to be retrieved.</param>


		public static ActionResult Getlicense(string @station
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, false, "station.getlicense", new {@station
});
		}

		

	}
}


