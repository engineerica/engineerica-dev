using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// List the id of the students expected during a period of time.  This action requires authentication.
		/// </summary>
		/// <param name="_classroomid">The classroom to get the users.</param>


		public ActionResult Listexpected(Guid _classroomid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.listexpected", new {_classroomid
});
		}

		
		/// <summary>
		/// List the id of the students expected during a period of time
		/// </summary>
		/// <param name="_classroomid">The classroom to get the users.</param>
		/// <param name="_nextdays">The period (in days) to get the expected users, default 7.</param>


		public ActionResult Listexpected(Guid _classroomid, int _nextdays
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.listexpected", new {_classroomid, _nextdays
});
		}

		

	}
}


