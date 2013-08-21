using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public partial class Station : ActionSet
	{
		
		/// <summary>
		/// List sign-in stations.  This action requires authentication.
		/// </summary>
		/// <param name="_from">The first record to return.</param>
		/// <param name="_count">The max number of records to return.</param>


		public ActionResult List(int _from, int _count
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.list", new {_from, _count
});
		}

		

	}
}


