using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public static partial class Station
	{
		
		/// <summary>
		/// Saves a sign-in station.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The friendly name of the sign-in station.</param>
		/// <param name="@mode">The mode of the sign-in station.</param>
		/// <param name="@passcode">The passcode used to change settings in the station, empty text to disable security.</param>


		public static ActionResult Save(string @name, string @mode, string @passcode
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "station.save", new {@name, @mode, @passcode
});
		}

		
		/// <summary>
		/// Saves a sign-in station
		/// </summary>
		/// <param name="@name">The friendly name of the sign-in station.</param>
		/// <param name="@mode">The mode of the sign-in station.</param>
		/// <param name="@passcode">The passcode used to change settings in the station, empty text to disable security.</param>
		/// <param name="@id">The id of the sign-in station to save (leave empty to create a new one).</param>
		/// <param name="@title">Title to display in the station.</param>
		/// <param name="@instructions">Instructions to display in the station.</param>
		/// <param name="@location">Id of the location Title to display in the station.</param>
		/// <param name="@shownames">Whether to show the visitor names in the sign-in station.</param>
		/// <param name="@showphotos">Whether to show the visitor photos in the sign-in station.</param>
		/// <param name="@photopixelwidth">Specifies the pixel width of the photos in the sign-in station.</param>
		/// <param name="@allowcreatingvisitors">Whether to allow creating visitors from the sign-in station.</param>


		public static ActionResult Save(string @name, string @mode, string @passcode, Guid @id, string @title, string @instructions, Guid @location, bool @shownames, bool @showphotos, int @photopixelwidth, bool @allowcreatingvisitors
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "station.save", new {@name, @mode, @passcode, @id, @title, @instructions, @location, @shownames, @showphotos, @photopixelwidth, @allowcreatingvisitors
});
		}

		

	}
}


