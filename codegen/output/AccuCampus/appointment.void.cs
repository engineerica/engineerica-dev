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
		/// Void an appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to cancel.</param>


		public static ActionResult Void(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.void", new {@id
});
		}

		

	}
}


