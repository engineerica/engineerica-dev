using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public partial class Session : ActionSet
	{
		
		/// <summary>
		/// Bulk updates the class sessions.  This action requires authentication.
		/// </summary>
		/// <param name="_classid">The id of the class to bulk update.</param>
		/// <param name="_sessions">A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.</param>


		public ActionResult Bulkupdate(Guid _classid, string _sessions
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "session.bulkupdate", new {_classid, _sessions
});
		}

		

	}
}


