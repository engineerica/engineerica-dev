using System;

namespace EngineericaApi.AccuWB
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
		/// <param name="@middlename">The middle name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@email">The email of the user.</param>
		/// <param name="@roles">Comma separated list of roles of the user.</param>


		public static ActionResult Save(string @firstname, string @middlename, string @lastname, string @email, string @roles
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "user.save", new {@firstname, @middlename, @lastname, @email, @roles
});
		}

		
		/// <summary>
		/// Saves user
		/// </summary>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@middlename">The middle name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@email">The email of the user.</param>
		/// <param name="@roles">Comma separated list of roles of the user.</param>
		/// <param name="@id">The id of the user to save (leave empty to create a new one).</param>
		/// <param name="@password">The new password of the user.</param>


		public static ActionResult Save(string @firstname, string @middlename, string @lastname, string @email, string @roles, Guid @id, string @password
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "user.save", new {@firstname, @middlename, @lastname, @email, @roles, @id, @password
});
		}

		

	}
}


