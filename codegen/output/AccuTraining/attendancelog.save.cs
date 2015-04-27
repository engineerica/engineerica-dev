using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Saves an attendance log.  This action requires authentication.
		/// </summary>


		public static ActionResult Save(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "attendancelog.save", new {
});
		}

		
		/// <summary>
		/// Saves an attendance log
		/// </summary>
		/// <param name="@id">The id of the room to save (leave empty to create a new one).</param>
		/// <param name="@cardnumber">The card # of the user (used when the user is unknown).</param>
		/// <param name="@user">The id of the user.</param>
		/// <param name="@location">The id of the location where the user signed in.</param>
		/// <param name="@event">The id of the event the user signed in to.</param>
		/// <param name="@logdetails">The log details in JSON format</param>


		public static ActionResult Save(Guid @id, Guid @cardnumber, Guid @user, Guid @location, Guid @event, Guid @logdetails
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "attendancelog.save", new {@id, @cardnumber, @user, @location, @event, @logdetails
});
		}

		

	}
}


