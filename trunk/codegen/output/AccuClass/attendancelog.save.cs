using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Saves an attendance log.  This action requires authentication.
		/// </summary>


		public ActionResult Save(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.save", new {
});
		}

		
		/// <summary>
		/// Saves an attendance log
		/// </summary>
		/// <param name="_id">The id of the att log to save (leave empty to create a new one).</param>
		/// <param name="_date">The sign-in date and time in ISO format, if not specified the session date and time will be used.</param>
		/// <param name="_session">The id of the session where the user signed in.</param>
		/// <param name="_user">The id of the student. If null then all the class session will be updated.</param>
		/// <param name="_status">The attendance status of the student in this session.</param>
		/// <param name="_notes">The text of the note to add.</param>
		/// <param name="_totalminutes">The total time, in minutes, the students was in.</param>


		public ActionResult Save(Guid _id, DateTime _date, Guid _session, Guid _user, string _status, string _notes, int _totalminutes
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.save", new {_id, _date, _session, _user, _status, _notes, _totalminutes
});
		}

		

	}
}


