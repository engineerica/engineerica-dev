using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Finds similar users to prevent duplicates.  This action requires authentication.
		/// </summary>


		public static ActionResult Findsimilar(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "user.findsimilar", new {
});
		}

		
		/// <summary>
		/// Finds similar users to prevent duplicates
		/// </summary>
		/// <param name="@currentid">The id of the current user.</param>
		/// <param name="@phonenumber">A phone number to search for similar users.</param>
		/// <param name="@cardnumber">A card number to search for similar users.</param>


		public static ActionResult Findsimilar(Guid @currentid, string @phonenumber, string @cardnumber
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "user.findsimilar", new {@currentid, @phonenumber, @cardnumber
});
		}

		

	}
}


