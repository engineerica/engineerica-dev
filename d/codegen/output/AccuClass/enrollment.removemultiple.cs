using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public static partial class Enrollment
	{
		
		/// <summary>
		/// Unenrolls several students from a class.  This action requires authentication.
		/// </summary>
		/// <param name="@users">List of IDs of students to unenroll. One per line.</param>
		/// <param name="@classid">The id of the class to unenroll.</param>


		public static ActionResult Removemultiple(string @users, Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.removemultiple", new {@users, @classid
});
		}

		

	}
}


