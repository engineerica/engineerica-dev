using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public partial class Enrollment : ActionSet
	{
		
		/// <summary>
		/// Enrolls a student to a class.  This action requires authentication.
		/// </summary>
		/// <param name="_userid">The id of the user to enroll.</param>
		/// <param name="_classid">The id of the class to enroll.</param>


		public ActionResult Add(Guid _userid, Guid _classid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "enrollment.add", new {_userid, _classid
});
		}

		

	}
}


