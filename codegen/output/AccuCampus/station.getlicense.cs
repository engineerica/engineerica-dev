using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "station.getlicense", new {@station
});
		}

		

	}
}


