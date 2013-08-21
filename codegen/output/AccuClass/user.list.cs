using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// List users.  This action requires authentication.
		/// </summary>
		/// <param name="_from">The first record to return.</param>
		/// <param name="_count">The max number of records to return.</param>


		public ActionResult List(int _from, int _count
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.list", new {_from, _count
});
		}

		
		/// <summary>
		/// List users
		/// </summary>
		/// <param name="_from">The first record to return.</param>
		/// <param name="_count">The max number of records to return.</param>
		/// <param name="_role">The role to filter users by, or empty to return all users.</param>
		/// <param name="_photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public ActionResult List(int _from, int _count, string _role, int _photosize
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.list", new {_from, _count, _role, _photosize
});
		}

		

	}
}


