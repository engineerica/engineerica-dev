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
		/// Get the sign-in station settings of a specified location
		/// </summary>
		/// <param name="@location">The id of the location whose station settings have to be returned.</param>


		public static ActionResult Getlocationsettings(Guid @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "station.getlocationsettings", new {@location
});
		}

		

	}
}


