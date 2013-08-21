using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public partial class Station : ActionSet
	{
		
		/// <summary>
		/// Gets a the info to display in the sign-in station by it's ID.
		/// </summary>
		/// <param name="_id">The id of the sign-in station to get.</param>
		/// <param name="_session">The id of the session, to overwrite the current session.</param>


		public ActionResult Getinfo(Guid _id, Guid _session
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.getinfo", new {_id, _session
});
		}

		

	}
}


