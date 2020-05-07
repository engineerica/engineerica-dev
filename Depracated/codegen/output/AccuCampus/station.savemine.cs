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
		/// Save a class attendance sign-in station for the logged-in user.  This action requires authentication.
		/// </summary>
		/// <param name="@mode">The mode of the sign-in station.</param>
		/// <param name="@passcode">The passcode used to change settings in the station, empty text to disable security.</param>


		public static ActionResult Savemine(string @mode, string @passcode
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "station.savemine", new {@mode, @passcode
});
		}

		
		/// <summary>
		/// Save a class attendance sign-in station for the logged-in user
		/// </summary>
		/// <param name="@mode">The mode of the sign-in station.</param>
		/// <param name="@passcode">The passcode used to change settings in the station, empty text to disable security.</param>
		/// <param name="@instructions">Instructions to display in the station.</param>
		/// <param name="@shownames">Whether to show the visitor names in the sign-in station.</param>
		/// <param name="@showphotos">Whether to show the visitor photos in the sign-in station.</param>


		public static ActionResult Savemine(string @mode, string @passcode, string @instructions, bool @shownames, bool @showphotos
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "station.savemine", new {@mode, @passcode, @instructions, @shownames, @showphotos
});
		}

		

	}
}


