using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Signs an attendance log out.  This action requires authentication.
		/// </summary>


		public static ActionResult Signout(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "attendancelog.signout", new {
});
		}

		
		/// <summary>
		/// Signs an attendance log out
		/// </summary>
		/// <param name="@id">The id of the attendance log to sign-out.</param>
		/// <param name="@location">The id of the location to filter the users to sign out.</param>
		/// <param name="@event">The id of the event to filter the users to sign out.</param>


		public static ActionResult Signout(Guid @id, Guid @location, Guid @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "attendancelog.signout", new {@id, @location, @event
});
		}

		

	}
}


