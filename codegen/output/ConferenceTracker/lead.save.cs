using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Saves a lead.  This action requires authentication.
		/// </summary>
		/// <param name="@date">The date in ISO format.</param>
		/// <param name="@exhibitor">The id of the exhibitor user.</param>
		/// <param name="@firstname">The first name of the attendee.</param>
		/// <param name="@lastname">The last name of the attendee.</param>


		public static ActionResult Save(DateTime @date, Guid @exhibitor, string @firstname, string @lastname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.save", new {@date, @exhibitor, @firstname, @lastname
});
		}

		
		/// <summary>
		/// Saves a lead
		/// </summary>
		/// <param name="@date">The date in ISO format.</param>
		/// <param name="@exhibitor">The id of the exhibitor user.</param>
		/// <param name="@firstname">The first name of the attendee.</param>
		/// <param name="@lastname">The last name of the attendee.</param>
		/// <param name="@id">The id of the lead to save.</param>
		/// <param name="@conference">The id of the conference whose lead is being saved.</param>
		/// <param name="@attendee">The id of the exhibitor attendee.</param>
		/// <param name="@middlename">The middle name of the attendee.</param>
		/// <param name="@email">The email of the attendee.</param>
		/// <param name="@phonenumber">The phone number of the attendee.</param>
		/// <param name="@streetaddress">The street address of the attendee.</param>
		/// <param name="@city">The city of the attendee.</param>
		/// <param name="@state">The state of the attendee.</param>
		/// <param name="@zipcode">The zip code of the attendee.</param>
		/// <param name="@title">The title of the attendee.</param>
		/// <param name="@companyid">The name company of the user.</param>
		/// <param name="@company">The name company of the user (If company is not set this is used to create a new company).</param>
		/// <param name="@notes">The notes of the attendee.</param>
		/// <param name="@surveyresponses">The lead custom survey responses (JSON-formatted).</param>
		/// <param name="@device">The unique id of the device whose lead has to be saved.</param>
		/// <param name="@devicename">The name of the device whose lead has to be saved.</param>


		public static ActionResult Save(DateTime @date, Guid @exhibitor, string @firstname, string @lastname, Guid @id, Guid @conference, Guid @attendee, string @middlename, string @email, string @phonenumber, string @streetaddress, string @city, string @state, string @zipcode, string @title, Guid @companyid, string @company, string @notes, string @surveyresponses, string @device, string @devicename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.save", new {@date, @exhibitor, @firstname, @lastname, @id, @conference, @attendee, @middlename, @email, @phonenumber, @streetaddress, @city, @state, @zipcode, @title, @companyid, @company, @notes, @surveyresponses, @device, @devicename
});
		}

		

	}
}


