using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public static partial class Enrollment
	{
		
		/// <summary>
		/// Enrolls several students to a class.  This action requires authentication.
		/// </summary>
		/// <param name="@users">List of IDs of students to enroll. One per line.</param>
		/// <param name="@classid">The id of the class to enroll.</param>


		public static ActionResult Addmultiple(string @users, Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.addmultiple", new {@users, @classid
});
		}

		

	}
}


