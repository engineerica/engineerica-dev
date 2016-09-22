using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
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
		/// <param name="@email">The email of the user.</param>


		public static ActionResult Save(string @firstname, string @lastname, string @email
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "user.save", new {@firstname, @lastname, @email
});
		}

		
		/// <summary>
		/// Saves user
		/// </summary>
		/// <param name="@firstname">The first name of the user.</param>
		/// <param name="@lastname">The last name of the user.</param>
		/// <param name="@email">The email of the user.</param>
		/// <param name="@id">The id of the user to save (leave empty to create a new one).</param>
		/// <param name="@middlename">The middle name of the user.</param>
		/// <param name="@mobilephonenumber">The mobile phone number of the user.</param>
		/// <param name="@homephonenumber">The home phone number of the user.</param>
		/// <param name="@workphonenumber">The work phone number of the user.</param>
		/// <param name="@streetaddress">The street address of the user.</param>
		/// <param name="@city">The city of the user.</param>
		/// <param name="@state">The state of the user.</param>
		/// <param name="@zipcode">The zip code of the user.</param>
		/// <param name="@title">The title of the user.</param>
		/// <param name="@company">The company of the user.</param>
		/// <param name="@password">The new password of the user.</param>
		/// <param name="@roles">Comma separated list of roles of the user.</param>
		/// <param name="@assigncard">True if a new card has to be assigned to the user, otherwise false.</param>
		/// <param name="@cardnumber">The card number that has to be assigned to the user.</param>
		/// <param name="@more">Custom data of the user</param>
		/// <param name="@photoid">The ID of a photo uploaded using user.loadphoto.</param>


		public static ActionResult Save(string @firstname, string @lastname, string @email, Guid @id, string @middlename, string @mobilephonenumber, string @homephonenumber, string @workphonenumber, string @streetaddress, string @city, string @state, string @zipcode, string @title, string @company, string @password, string @roles, string @assigncard, string @cardnumber, string @more, Guid @photoid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "user.save", new {@firstname, @lastname, @email, @id, @middlename, @mobilephonenumber, @homephonenumber, @workphonenumber, @streetaddress, @city, @state, @zipcode, @title, @company, @password, @roles, @assigncard, @cardnumber, @more, @photoid
});
		}

		

	}
}


