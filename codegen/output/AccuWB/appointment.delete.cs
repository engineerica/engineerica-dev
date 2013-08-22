using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Appointments.
	/// </summary>
	public static partial class Appointment
	{
		
		/// <summary>
		/// Deletes an appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the appointment to delete.</param>


		public static ActionResult Delete(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "appointment.delete", new {@id
});
		}

		

	}
}


