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
		/// View an appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.get", new {@id
});
		}

		

	}
}


