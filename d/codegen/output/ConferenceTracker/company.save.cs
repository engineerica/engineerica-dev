using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Companys.
	/// </summary>
	public static partial class Company
	{
		
		/// <summary>
		/// Save a company.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the company.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.save", new {@name
});
		}

		
		/// <summary>
		/// Save a company
		/// </summary>
		/// <param name="@name">The name of the company.</param>
		/// <param name="@id">The id of the company to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the company.</param>
		/// <param name="@categories">Pipe separated list of categories.</param>
		/// <param name="@email">The institutional e-mail address of the company.</param>
		/// <param name="@website">Website address of the company.</param>
		/// <param name="@booth">Booth number of the exhibitor company.</param>
		/// <param name="@phonenumber">The institutional phone number of the company.</param>
		/// <param name="@streetaddress">The street address of the company.</param>
		/// <param name="@city">The city of the company.</param>
		/// <param name="@state">The state of the company.</param>
		/// <param name="@zipcode">The zip code of the company.</param>
		/// <param name="@contactfirstname">The first name of the contact in the company.</param>
		/// <param name="@contactmiddlename">The middle name of the contact in the company.</param>
		/// <param name="@contactlastname">The last name of the contact in the company.</param>
		/// <param name="@contactemail">The e-mail address of the contact in the company.</param>
		/// <param name="@contactphonenumber">The phone number of the contact in the company.</param>


		public static ActionResult Save(string @name, Guid @id, string @description, string @categories, string @email, string @website, string @booth, string @phonenumber, string @streetaddress, string @city, string @state, string @zipcode, string @contactfirstname, string @contactmiddlename, string @contactlastname, string @contactemail, string @contactphonenumber
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.save", new {@name, @id, @description, @categories, @email, @website, @booth, @phonenumber, @streetaddress, @city, @state, @zipcode, @contactfirstname, @contactmiddlename, @contactlastname, @contactemail, @contactphonenumber
});
		}

		

	}
}


