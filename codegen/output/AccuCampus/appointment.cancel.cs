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
		/// Cancel an appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to cancel.</param>


		public static ActionResult Cancel(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.cancel", new {@id
});
		}

		

	}
}


