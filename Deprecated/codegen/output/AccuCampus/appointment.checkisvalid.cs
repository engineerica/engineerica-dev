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
		/// Check if an appointment is valid or not.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to check.</param>


		public static ActionResult Checkisvalid(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.checkisvalid", new {@id
});
		}

		
		/// <summary>
		/// Check if an appointment is valid or not
		/// </summary>
		/// <param name="@id">The id of the appointment to check.</param>
		/// <param name="@editing">Specifies whether the check is for a new appointment or an existing one.</param>


		public static ActionResult Checkisvalid(Guid @id, bool @editing
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.checkisvalid", new {@id, @editing
});
		}

		

	}
}


