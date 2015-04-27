using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Saves logged user's profile information.  This action requires authentication.
		/// </summary>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@email">The email of the user.</param>


		public static ActionResult Saveprofile(string @firstname, string @lastname, string @email
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "my.saveprofile", new {@firstname, @lastname, @email
});
		}

		
		/// <summary>
		/// Saves logged user's profile information
		/// </summary>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@email">The email of the user.</param>
		/// <param name="@middlename">The middle name of the user.</param>
		/// <param name="@phonenumber">The phone number of the user.</param>
		/// <param name="@streetaddress">The street address of the user.</param>
		/// <param name="@city">The city of the user.</param>
		/// <param name="@state">The state of the user.</param>
		/// <param name="@zipcode">The zip code of the user.</param>
		/// <param name="@title">The title of the user.</param>
		/// <param name="@company">The company of the user.</param>


		public static ActionResult Saveprofile(string @firstname, string @lastname, string @email, string @middlename, string @phonenumber, string @streetaddress, string @city, string @state, string @zipcode, string @title, string @company
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "my.saveprofile", new {@firstname, @lastname, @email, @middlename, @phonenumber, @streetaddress, @city, @state, @zipcode, @title, @company
});
		}

		

	}
}


