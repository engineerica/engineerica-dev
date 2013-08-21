using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Gets the attendance information for a specific student.  This action requires authentication.
		/// </summary>
		/// <param name="_student">The id of the student to get statistic for.</param>
		/// <param name="_classid">The id of the class whose student statatistics have to be returned.</param>


		public ActionResult Getuser(Guid _student, Guid _classid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.getuser", new {_student, _classid
});
		}

		

	}
}


