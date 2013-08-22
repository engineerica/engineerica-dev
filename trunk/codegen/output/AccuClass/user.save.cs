using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Saves user.  This action requires authentication.
		/// </summary>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@roles">Comma separated list of roles of the user.</param>


		public static ActionResult Save(string @firstname, string @lastname, string @roles
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.save", new {@firstname, @lastname, @roles
});
		}

		
		/// <summary>
		/// Saves user
		/// </summary>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@roles">Comma separated list of roles of the user.</param>
		/// <param name="@id">The id of the user to save (leave empty to create a new one).</param>
		/// <param name="@customid">The ID of the user, unique but can be  anything the user wants.</param>
		/// <param name="@middlename">The middle name of the user.</param>
		/// <param name="@email">The email of the user.</param>
		/// <param name="@card">The card number (can be text) of the user.</param>
		/// <param name="@password">The new password of the user.</param>
		/// <param name="@photoid">The ID of a photo uploaded using user.loadphoto.</param>


		public static ActionResult Save(string @firstname, string @lastname, string @roles, Guid @id, string @customid, string @middlename, string @email, string @card, string @password, Guid @photoid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.save", new {@firstname, @lastname, @roles, @id, @customid, @middlename, @email, @card, @password, @photoid
});
		}

		

	}
}


