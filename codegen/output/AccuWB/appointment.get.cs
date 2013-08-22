using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Appointments.
	/// </summary>
	public static partial class Appointment
	{
		
		/// <summary>
		/// Get appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to get.</param>


		public static ActionResult Get(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "appointment.get", new {@id
});
		}

		

	}
}


