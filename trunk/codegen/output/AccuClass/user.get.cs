using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// Get user.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the user to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.get", new {_id
});
		}

		
		/// <summary>
		/// Get user
		/// </summary>
		/// <param name="_id">The id of the user to get.</param>
		/// <param name="_photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public ActionResult Get(Guid _id, int _photosize
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.get", new {_id, _photosize
});
		}

		

	}
}


