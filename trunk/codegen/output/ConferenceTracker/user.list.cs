using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// List users.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "user.list", new {@from, @count
});
		}

		
		/// <summary>
		/// List users
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@role">The role to filter users by, or empty to return all users.</param>
		/// <param name="@onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param>


		public static ActionResult List(int @from, int @count, string @role, string @onlywithoutcard
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "user.list", new {@from, @count, @role, @onlywithoutcard
});
		}

		

	}
}


