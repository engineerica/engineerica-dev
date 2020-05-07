using System;

namespace EngineericaApi.ConferenceTracker
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "user.save", new {@firstname, @lastname, @email
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
		/// <param name="@phonenumber">The phone number of the user.</param>
		/// <param name="@streetaddress">The street address of the user.</param>
		/// <param name="@city">The city of the user.</param>
		/// <param name="@state">The state of the user.</param>
		/// <param name="@zipcode">The zip code of the user.</param>
		/// <param name="@title">The title of the user.</param>
		/// <param name="@companyid">The name company of the user.</param>
		/// <param name="@company">The name company of the user (If company is not set this is used to create a new company).</param>
		/// <param name="@password">The new password of the user.</param>
		/// <param name="@roles">Comma separated list of roles of the user.</param>
		/// <param name="@assigncard">True if a new card has to be assigned to the user, otherwise false.</param>
		/// <param name="@cardnumber">The card number that has to be assigned to the user.</param>
		/// <param name="@more">Custom data of the user</param>
		/// <param name="@cantrackleads">Whether the user can track leads or not.</param>
		/// <param name="@active">Whether the user is active or not.</param>
		/// <param name="@customfield1">Data of the custom field 1</param>
		/// <param name="@customfield2">Data of the custom field 2</param>
		/// <param name="@customfield3">Data of the custom field 3</param>
		/// <param name="@customfield4">Data of the custom field 4</param>
		/// <param name="@customfield5">Data of the custom field 5</param>


		public static ActionResult Save(string @firstname, string @lastname, string @email, Guid @id, string @middlename, string @phonenumber, string @streetaddress, string @city, string @state, string @zipcode, string @title, Guid @companyid, string @company, string @password, string @roles, string @assigncard, string @cardnumber, string @more, bool @cantrackleads, bool @active, string @customfield1, string @customfield2, string @customfield3, string @customfield4, string @customfield5
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "user.save", new {@firstname, @lastname, @email, @id, @middlename, @phonenumber, @streetaddress, @city, @state, @zipcode, @title, @companyid, @company, @password, @roles, @assigncard, @cardnumber, @more, @cantrackleads, @active, @customfield1, @customfield2, @customfield3, @customfield4, @customfield5
});
		}

		

	}
}


