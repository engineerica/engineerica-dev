using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Gets the schedule for a location, instructor or attendees.  This action requires authentication.
		/// </summary>


		public static ActionResult Getschedule(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "session.getschedule", new {
});
		}

		
		/// <summary>
		/// Gets the schedule for a location, instructor or attendees
		/// </summary>
		/// <param name="@day">The day to return. It will also return the whole week for that day.</param>
		/// <param name="@attendee">The id of the attendee to get the schedule.</param>
		/// <param name="@location">The id of the location to get the schedule.</param>
		/// <param name="@instructor">The id of the instructor to get the schedule.</param>


		public static ActionResult Getschedule(DateTime @day, Guid @attendee, Guid @location, Guid @instructor
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "session.getschedule", new {@day, @attendee, @location, @instructor
});
		}

		

	}
}


