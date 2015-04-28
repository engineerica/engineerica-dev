using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Get user.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the user to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "user.get", new {@id
});
		}

		
		/// <summary>
		/// Get user
		/// </summary>
		/// <param name="@id">The id of the user to get.</param>
		/// <param name="@photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public static ActionResult Get(Guid @id, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "user.get", new {@id, @photosize
});
		}

		

	}
}


