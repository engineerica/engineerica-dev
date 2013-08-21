using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public partial class Station : ActionSet
	{
		
		/// <summary>
		/// Deletes a sign-in station.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the sign-in station to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.delete", new {_id
});
		}

		

	}
}


