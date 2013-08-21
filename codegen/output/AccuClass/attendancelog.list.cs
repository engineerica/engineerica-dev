using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Gets the attendance logs of the specified session.  This action requires authentication.
		/// </summary>
		/// <param name="_session">The id of the session whose students logs have to be returned.</param>
		/// <param name="_from">The first record to return.</param>
		/// <param name="_count">The max number of records to return.</param>


		public ActionResult List(Guid _session, int _from, int _count
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.list", new {_session, _from, _count
});
		}

		

	}
}


