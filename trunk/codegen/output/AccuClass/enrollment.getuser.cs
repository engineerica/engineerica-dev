using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public partial class Enrollment : ActionSet
	{
		
		/// <summary>
		/// Gets the enrollment for the specified user.  This action requires authentication.
		/// </summary>
		/// <param name="_userid">The id of the user to get enrollment.</param>


		public ActionResult Getuser(Guid _userid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "enrollment.getuser", new {_userid
});
		}

		
		/// <summary>
		/// Gets the enrollment for the specified user
		/// </summary>
		/// <param name="_userid">The id of the user to get enrollment.</param>
		/// <param name="_semesterid">The id of the semester to get enrollment, the current one will be used if not specified.</param>


		public ActionResult Getuser(Guid _userid, Guid _semesterid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "enrollment.getuser", new {_userid, _semesterid
});
		}

		

	}
}


