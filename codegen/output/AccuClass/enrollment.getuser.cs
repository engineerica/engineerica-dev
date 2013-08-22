using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public static partial class Enrollment
	{
		
		/// <summary>
		/// Gets the enrollment for the specified user.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to get enrollment.</param>


		public static ActionResult Getuser(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.getuser", new {@userid
});
		}

		
		/// <summary>
		/// Gets the enrollment for the specified user
		/// </summary>
		/// <param name="@userid">The id of the user to get enrollment.</param>
		/// <param name="@semesterid">The id of the semester to get enrollment, the current one will be used if not specified.</param>


		public static ActionResult Getuser(Guid @userid, Guid @semesterid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.getuser", new {@userid, @semesterid
});
		}

		

	}
}


