using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public partial class Enrollment : ActionSet
	{
		
		/// <summary>
		/// Removes a class from the student enrollment.  This action requires authentication.
		/// </summary>
		/// <param name="_userid">The id of the user to enroll.</param>
		/// <param name="_classid">The id of the class to enroll.</param>
		/// <param name="_drop">True to mark it as dropped, false to completely remove the class</param>


		public ActionResult Remove(Guid _userid, Guid _classid, bool _drop
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "enrollment.remove", new {_userid, _classid, _drop
});
		}

		

	}
}


