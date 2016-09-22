using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance summary by semester.  This action requires authentication.
		/// </summary>
		/// <param name="@semesterid">The id of the semester to get the summary.</param>
		/// <param name="@from">The first class to return.</param>
		/// <param name="@count">The max number of classes to return. The number to total records returned can be different.</param>


		public static ActionResult Summarybysemester(Guid @semesterid, int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.summarybysemester", new {@semesterid, @from, @count
});
		}

		

	}
}


