using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Advroless.
	/// </summary>
	public static partial class Advroles
	{
		
		/// <summary>
		/// List users. Alias to user.list, use that one instead..  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Userlist(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advroles.userlist", new {@from, @count
});
		}

		
		/// <summary>
		/// List users. Alias to user.list, use that one instead.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@roleid">The id of the role to filter users by, or empty to return all users.</param>
		/// <param name="@onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param>
		/// <param name="@photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public static ActionResult Userlist(int @from, int @count, Guid @roleid, string @onlywithoutcard, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advroles.userlist", new {@from, @count, @roleid, @onlywithoutcard, @photosize
});
		}

		

	}
}


