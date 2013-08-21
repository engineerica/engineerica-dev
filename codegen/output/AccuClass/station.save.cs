using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public partial class Station : ActionSet
	{
		
		/// <summary>
		/// Saves a sign-in station.  This action requires authentication.
		/// </summary>
		/// <param name="_name">The friendly name of the sign-in station.</param>
		/// <param name="_passcode">The passcode used to change settings in the station, empty text to disable security.</param>


		public ActionResult Save(string _name, string _passcode
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.save", new {_name, _passcode
});
		}

		
		/// <summary>
		/// Saves a sign-in station
		/// </summary>
		/// <param name="_name">The friendly name of the sign-in station.</param>
		/// <param name="_passcode">The passcode used to change settings in the station, empty text to disable security.</param>
		/// <param name="_id">The id of the sign-in station to save (leave empty to create a new one).</param>
		/// <param name="_title">Title to display in the station.</param>
		/// <param name="_instructions">Instructions to display in the station.</param>
		/// <param name="_classroom">Id of the classroom Title to display in the station.</param>
		/// <param name="_shownames">Whether to show the student names in the sign-in station.</param>
		/// <param name="_showphotos">Whether to show the student photos in the sign-in station.</param>


		public ActionResult Save(string _name, string _passcode, Guid _id, string _title, string _instructions, Guid _classroom, bool _shownames, bool _showphotos
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.save", new {_name, _passcode, _id, _title, _instructions, _classroom, _shownames, _showphotos
});
		}

		

	}
}


