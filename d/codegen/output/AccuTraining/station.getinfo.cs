using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
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


		public static ActionResult Getinfo(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "station.getinfo", new {@id
});
		}

		
		/// <summary>
		/// Gets a the info to display in the sign-in station by it's ID.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to get.</param>
		/// <param name="@event">The id of the event, to override the one by schedule.</param>


		public static ActionResult Getinfo(Guid @id, Guid @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "station.getinfo", new {@id, @event
});
		}

		

	}
}


