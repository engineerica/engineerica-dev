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
		/// Mark an attendee as show or no-show on an appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to edit its presence.</param>
		/// <param name="@showedup">Specifies whether the attendee was showed-up or not in the appointment.</param>


		public static ActionResult Editpresence(Guid @id, bool @showedup
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.editpresence", new {@id, @showedup
});
		}

		

	}
}


