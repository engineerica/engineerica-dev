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
		/// Bypass appointment validations and restore it manually.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to restore.</param>


		public static ActionResult Restoreanyway(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.restoreanyway", new {@id
});
		}

		

	}
}


