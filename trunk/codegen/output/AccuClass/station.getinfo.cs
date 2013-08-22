using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public static partial class Station
	{
		
		/// <summary>
		/// Gets a the info to display in the sign-in station by it's ID.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to get.</param>
		/// <param name="@session">The id of the session, to overwrite the current session.</param>


		public static ActionResult Getinfo(Guid @id, Guid @session
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "station.getinfo", new {@id, @session
});
		}

		

	}
}


