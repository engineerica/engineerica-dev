using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Appointments.
	/// </summary>
	public static partial class Appointment
	{
		
		/// <summary>
		/// Make an appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@attendee">The id of the attendee involved in the appointment.</param>
		/// <param name="@staff">The id of the staff member involved in the appointment.</param>
		/// <param name="@location">The id of the location where the appointment will take place.</param>
		/// <param name="@start">The appointment's start date & time.</param>
		/// <param name="@end">The appointment's end date & time.</param>


		public static ActionResult Save(Guid @attendee, Guid @staff, Guid @location, DateTime @start, DateTime @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.save", new {@attendee, @staff, @location, @start, @end
});
		}

		
		/// <summary>
		/// Make an appointment
		/// </summary>
		/// <param name="@attendee">The id of the attendee involved in the appointment.</param>
		/// <param name="@staff">The id of the staff member involved in the appointment.</param>
		/// <param name="@location">The id of the location where the appointment will take place.</param>
		/// <param name="@start">The appointment's start date & time.</param>
		/// <param name="@end">The appointment's end date & time.</param>
		/// <param name="@id">The id of the appointment to save (leave empty to create a new one).</param>
		/// <param name="@event">The id of the event of the appointment.</param>
		/// <param name="@services">Comma-separated string containing the ids of the services of the appointment.</param>
		/// <param name="@notes">The notes of the appointment.</param>


		public static ActionResult Save(Guid @attendee, Guid @staff, Guid @location, DateTime @start, DateTime @end, Guid @id, Guid? @event, string @services, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.save", new {@attendee, @staff, @location, @start, @end, @id, @event, @services, @notes
});
		}

		

	}
}


