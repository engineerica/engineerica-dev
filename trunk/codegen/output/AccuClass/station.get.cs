using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public static partial class Station
	{
		
		/// <summary>
		/// Gets a sign-in station by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "station.get", new {@id
});
		}

		

	}
}


