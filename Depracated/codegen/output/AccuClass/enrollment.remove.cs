using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public static partial class Enrollment
	{
		
		/// <summary>
		/// Removes a class from the student enrollment.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to enroll.</param>
		/// <param name="@classid">The id of the class to enroll.</param>
		/// <param name="@drop">True to mark it as dropped, false to completely remove the class</param>


		public static ActionResult Remove(Guid @userid, Guid @classid, bool @drop
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.remove", new {@userid, @classid, @drop
});
		}

		

	}
}


