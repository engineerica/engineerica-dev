using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public static partial class Enrollment
	{
		
		/// <summary>
		/// Enrolls a student to a class.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to enroll.</param>
		/// <param name="@classid">The id of the class to enroll.</param>


		public static ActionResult Add(Guid @userid, Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.add", new {@userid, @classid
});
		}

		

	}
}


