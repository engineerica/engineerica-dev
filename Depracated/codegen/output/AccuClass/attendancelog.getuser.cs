using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance information for a specific student.  This action requires authentication.
		/// </summary>
		/// <param name="@student">The id of the student to get statistic for.</param>
		/// <param name="@classid">The id of the class whose student statatistics have to be returned.</param>


		public static ActionResult Getuser(Guid @student, Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.getuser", new {@student, @classid
});
		}

		

	}
}


