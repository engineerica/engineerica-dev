using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Gets the schedule for a classroom, instructor or students.  This action requires authentication.
		/// </summary>


		public static ActionResult Getschedule(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "session.getschedule", new {
});
		}

		
		/// <summary>
		/// Gets the schedule for a classroom, instructor or students
		/// </summary>
		/// <param name="@day">The day to return. It will also return the whole week for that day.</param>
		/// <param name="@student">The Id of the student to get the schedule.</param>
		/// <param name="@classroom">The Id of the classroom to get the schedule.</param>
		/// <param name="@instructor">The Id of the instructor to get the schedule.</param>


		public static ActionResult Getschedule(DateTime @day, Guid @student, Guid @classroom, Guid @instructor
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "session.getschedule", new {@day, @student, @classroom, @instructor
});
		}

		

	}
}


