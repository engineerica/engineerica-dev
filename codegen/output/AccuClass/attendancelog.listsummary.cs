using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance summary for a class and/or a student.  This action requires authentication.
		/// </summary>


		public static ActionResult Listsummary(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.listsummary", new {
});
		}

		
		/// <summary>
		/// Gets the attendance summary for a class and/or a student
		/// </summary>
		/// <param name="@classid">The id of the class whose students attendance have to be returned.</param>
		/// <param name="@studentid">The id of the student whom attendance have to be returned.</param>
		/// <param name="@start">The start date to filter (beginning of time by default).</param>
		/// <param name="@end">The end date to filter (today by default).</param>


		public static ActionResult Listsummary(Guid @classid, Guid @studentid, string @start, string @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.listsummary", new {@classid, @studentid, @start, @end
});
		}

		

	}
}


