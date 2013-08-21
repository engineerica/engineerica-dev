using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public partial class Session : ActionSet
	{
		
		/// <summary>
		/// Gets the schedule for a classroom, instructor or students.  This action requires authentication.
		/// </summary>


		public ActionResult Getschedule(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "session.getschedule", new {
});
		}

		
		/// <summary>
		/// Gets the schedule for a classroom, instructor or students
		/// </summary>
		/// <param name="_day">The day to return. It will also return the whole week for that day.</param>
		/// <param name="_student">The Id of the student to get the schedule.</param>
		/// <param name="_classroom">The Id of the classroom to get the schedule.</param>
		/// <param name="_instructor">The Id of the instructor to get the schedule.</param>


		public ActionResult Getschedule(DateTime _day, Guid _student, Guid _classroom, Guid _instructor
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "session.getschedule", new {_day, _student, _classroom, _instructor
});
		}

		

	}
}


