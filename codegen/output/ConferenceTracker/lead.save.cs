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
		/// <param name="@id">The id of the lead to save (leave empty to create a new one).</param>
		/// <param name="@sourceid">The id given to the lead in the device where it was created.</param>
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
		/// <param name="@company">The company of the attendee.</param>
		/// <param name="@notes">The notes of the attendee.</param>


		public static ActionResult Save(DateTime @date, Guid @exhibitor, string @firstname, string @lastname, Guid @id, Guid @sourceid, Guid @conference, Guid @attendee, string @middlename, string @email, string @phonenumber, string @streetaddress, string @city, string @state, string @zipcode, string @title, string @company, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.save", new {@date, @exhibitor, @firstname, @lastname, @id, @sourceid, @conference, @attendee, @middlename, @email, @phonenumber, @streetaddress, @city, @state, @zipcode, @title, @company, @notes
});
		}

		

	}
}


