using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Creates a new user from a sign-in station
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>


		public static ActionResult Saveanonym(Guid @station, string @firstname, string @lastname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "user.saveanonym", new {@station, @firstname, @lastname
});
		}

		
		/// <summary>
		/// Creates a new user from a sign-in station
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@customid">The ID of the user, unique but can be  anything the user wants.</param>
		/// <param name="@middlename">The middle name of the user.</param>
		/// <param name="@email">The email of the user.</param>
		/// <param name="@card">The card number (can be text) of the user.</param>
		/// <param name="@photoid">The ID of a photo uploaded using user.loadphoto.</param>


		public static ActionResult Saveanonym(Guid @station, string @firstname, string @lastname, string @customid, string @middlename, string @email, string @card, Guid @photoid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "user.saveanonym", new {@station, @firstname, @lastname, @customid, @middlename, @email, @card, @photoid
});
		}

		

	}
}


