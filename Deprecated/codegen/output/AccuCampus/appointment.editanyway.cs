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
		/// Edit appointment by-passing validations.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to edit.</param>
		/// <param name="@attendee">The id of the attendee involved in the appointment.</param>
		/// <param name="@staff">The id of the staff member involved in the appointment.</param>
		/// <param name="@location">The id of the location where the appointment will take place.</param>
		/// <param name="@start">The appointment's start date & time.</param>
		/// <param name="@end">The appointment's end date & time.</param>


		public static ActionResult Editanyway(Guid @id, Guid @attendee, Guid @staff, Guid @location, DateTime @start, DateTime @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.editanyway", new {@id, @attendee, @staff, @location, @start, @end
});
		}

		
		/// <summary>
		/// Edit appointment by-passing validations
		/// </summary>
		/// <param name="@id">The id of the appointment to edit.</param>
		/// <param name="@attendee">The id of the attendee involved in the appointment.</param>
		/// <param name="@staff">The id of the staff member involved in the appointment.</param>
		/// <param name="@location">The id of the location where the appointment will take place.</param>
		/// <param name="@start">The appointment's start date & time.</param>
		/// <param name="@end">The appointment's end date & time.</param>
		/// <param name="@event">The id of the event of the appointment.</param>
		/// <param name="@services">Comma-separated string containing the ids of the services of the appointment.</param>
		/// <param name="@notes">The notes of the appointment.</param>


		public static ActionResult Editanyway(Guid @id, Guid @attendee, Guid @staff, Guid @location, DateTime @start, DateTime @end, Guid? @event, string @services, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.editanyway", new {@id, @attendee, @staff, @location, @start, @end, @event, @services, @notes
});
		}

		

	}
}


