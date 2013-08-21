using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Gets the attendance summary for a class and/or a student.  This action requires authentication.
		/// </summary>


		public ActionResult Listsummary(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.listsummary", new {
});
		}

		
		/// <summary>
		/// Gets the attendance summary for a class and/or a student
		/// </summary>
		/// <param name="_classid">The id of the class whose students attendance have to be returned.</param>
		/// <param name="_studentid">The id of the student whom attendance have to be returned.</param>
		/// <param name="_start">The start date to filter (beginning of time by default).</param>
		/// <param name="_end">The end date to filter (today by default).</param>


		public ActionResult Listsummary(Guid _classid, Guid _studentid, string _start, string _end
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.listsummary", new {_classid, _studentid, _start, _end
});
		}

		

	}
}


