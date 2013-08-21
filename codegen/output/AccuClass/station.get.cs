using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public partial class Station : ActionSet
	{
		
		/// <summary>
		/// Gets a sign-in station by Id.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the sign-in station to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.get", new {_id
});
		}

		

	}
}


