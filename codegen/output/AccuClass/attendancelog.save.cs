using System;

namespace EngineericaApi.AccuClass
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.save", new {
});
		}

		
		/// <summary>
		/// Saves an attendance log
		/// </summary>
		/// <param name="@id">The id of the att log to save (leave empty to create a new one).</param>
		/// <param name="@date">The sign-in date and time in ISO format, if not specified the session date and time will be used.</param>
		/// <param name="@session">The id of the session where the user signed in.</param>
		/// <param name="@user">The id of the student. If null then all the class session will be updated.</param>
		/// <param name="@status">The attendance status of the student in this session.</param>
		/// <param name="@notes">The text of the note to add.</param>
		/// <param name="@totalminutes">The total time, in minutes, the students was in.</param>
		/// <param name="@logdetails">A JSON-serialized array of details, containing Id, Time and Type.</param>


		public static ActionResult Save(Guid @id, DateTime @date, Guid @session, Guid @user, string @status, string @notes, int @totalminutes, string @logdetails
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.save", new {@id, @date, @session, @user, @status, @notes, @totalminutes, @logdetails
});
		}

		

	}
}


