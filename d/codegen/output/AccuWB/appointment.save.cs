using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Appointments.
	/// </summary>
	public static partial class Appointment
	{
		
		/// <summary>
		/// Saves appointment.  This action requires authentication.
		/// </summary>
		/// <param name="@title">The title of the appointment.</param>
		/// <param name="@starttime">The date and time when the appointment starts.</param>
		/// <param name="@duration">The duration of the appointment.</param>
		/// <param name="@room">The room Id where the appointment will take place.</param>


		public static ActionResult Save(string @title, DateTime @starttime, int @duration, string @room
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "appointment.save", new {@title, @starttime, @duration, @room
});
		}

		
		/// <summary>
		/// Saves appointment
		/// </summary>
		/// <param name="@title">The title of the appointment.</param>
		/// <param name="@starttime">The date and time when the appointment starts.</param>
		/// <param name="@duration">The duration of the appointment.</param>
		/// <param name="@room">The room Id where the appointment will take place.</param>
		/// <param name="@id">The id of the appointment to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the appointment.</param>
		/// <param name="@guests">A comma-separated list of the attendees' emails. Semicolon and line breakes are also supported as separators.</param>


		public static ActionResult Save(string @title, DateTime @starttime, int @duration, string @room, string @id, string @description, string @guests
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "appointment.save", new {@title, @starttime, @duration, @room, @id, @description, @guests
});
		}

		

	}
}


