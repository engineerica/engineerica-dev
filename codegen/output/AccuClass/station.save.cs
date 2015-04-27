using System;

namespace EngineericaApi.AccuClass
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "station.save", new {@name, @mode, @passcode
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
		/// <param name="@classroom">Id of the classroom Title to display in the station.</param>
		/// <param name="@instructor">Id of the instructor whose schedule should be displayed an the station.</param>
		/// <param name="@shownames">Whether to show the student names in the sign-in station.</param>
		/// <param name="@showphotos">Whether to show the student photos in the sign-in station.</param>
		/// <param name="@allowcreatingstudents">Whether to allow creating students from the sign-in station.</param>


		public static ActionResult Save(string @name, string @mode, string @passcode, Guid @id, string @title, string @instructions, Guid @classroom, Guid @instructor, bool @shownames, bool @showphotos, bool @allowcreatingstudents
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "station.save", new {@name, @mode, @passcode, @id, @title, @instructions, @classroom, @instructor, @shownames, @showphotos, @allowcreatingstudents
});
		}

		

	}
}


