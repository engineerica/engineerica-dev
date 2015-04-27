using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionattendancelogs.
	/// </summary>
	public static partial class Sessionattendancelog
	{
		
		/// <summary>
		/// Gets the attendance summary for an event and/or an attendee.  This action requires authentication.
		/// </summary>


		public static ActionResult Listsummary(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.listsummary", new {
});
		}

		
		/// <summary>
		/// Gets the attendance summary for an event and/or an attendee
		/// </summary>
		/// <param name="@eventid">The id of the event whose attendance has to be returned.</param>
		/// <param name="@attendeeid">The id of the attendee whose attendance has to be returned.</param>
		/// <param name="@groupid">The id of the group whose attendance has to be returned.</param>
		/// <param name="@start">The start date to filter (beginning of time by default).</param>
		/// <param name="@end">The end date to filter (today by default).</param>


		public static ActionResult Listsummary(Guid @eventid, Guid @attendeeid, Guid @groupid, string @start, string @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.listsummary", new {@eventid, @attendeeid, @groupid, @start, @end
});
		}

		

	}
}


