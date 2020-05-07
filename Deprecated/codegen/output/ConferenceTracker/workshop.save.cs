using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshops.
	/// </summary>
	public static partial class Workshop
	{
		
		/// <summary>
		/// Saves a workshop.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the workshop.</param>
		/// <param name="@starttime">The start date and time of the workshop, in ISO format.</param>
		/// <param name="@endtime">The end time of the workshop, in ISO format.</param>
		/// <param name="@room">The id of the room where it takes place.</param>
		/// <param name="@conference">The id of the conference where the workshop takes place.</param>
		/// <param name="@requiresignout">Specifies if the workshop requires sign-out</param>
		/// <param name="@requiredpresencepctg">The required presence % that attendees must have to be counted as present</param>


		public static ActionResult Save(string @name, DateTime @starttime, DateTime @endtime, Guid @room, Guid @conference, bool @requiresignout, int @requiredpresencepctg
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.save", new {@name, @starttime, @endtime, @room, @conference, @requiresignout, @requiredpresencepctg
});
		}

		
		/// <summary>
		/// Saves a workshop
		/// </summary>
		/// <param name="@name">The name of the workshop.</param>
		/// <param name="@starttime">The start date and time of the workshop, in ISO format.</param>
		/// <param name="@endtime">The end time of the workshop, in ISO format.</param>
		/// <param name="@room">The id of the room where it takes place.</param>
		/// <param name="@conference">The id of the conference where the workshop takes place.</param>
		/// <param name="@requiresignout">Specifies if the workshop requires sign-out</param>
		/// <param name="@requiredpresencepctg">The required presence % that attendees must have to be counted as present</param>
		/// <param name="@id">The id of the workshop to save (leave empty to create a new one).</param>
		/// <param name="@credits">The credits of the workshop.</param>
		/// <param name="@capacity">The capacity of the workshop.</param>
		/// <param name="@fee">The fee of the workshop.</param>
		/// <param name="@speakers">The speakers of the workshop.</param>
		/// <param name="@description">The description of the workshop.</param>
		/// <param name="@onlineregistrationenabled">Specifies if this workshop must be available for online registration or not.</param>
		/// <param name="@customfield1">Data of the custom field 1</param>
		/// <param name="@customfield2">Data of the custom field 2</param>
		/// <param name="@customfield3">Data of the custom field 3</param>
		/// <param name="@customfield4">Data of the custom field 4</param>
		/// <param name="@customfield5">Data of the custom field 5</param>


		public static ActionResult Save(string @name, DateTime @starttime, DateTime @endtime, Guid @room, Guid @conference, bool @requiresignout, int @requiredpresencepctg, Guid @id, decimal @credits, int @capacity, decimal @fee, string @speakers, string @description, bool @onlineregistrationenabled, string @customfield1, string @customfield2, string @customfield3, string @customfield4, string @customfield5
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.save", new {@name, @starttime, @endtime, @room, @conference, @requiresignout, @requiredpresencepctg, @id, @credits, @capacity, @fee, @speakers, @description, @onlineregistrationenabled, @customfield1, @customfield2, @customfield3, @customfield4, @customfield5
});
		}

		

	}
}


