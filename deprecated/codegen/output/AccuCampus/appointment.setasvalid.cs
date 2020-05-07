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
		/// Bypass appointment validations and make it valid manually.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to set as valid.</param>


		public static ActionResult Setasvalid(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.setasvalid", new {@id
});
		}

		

	}
}


