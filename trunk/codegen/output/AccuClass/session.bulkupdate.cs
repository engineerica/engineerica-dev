using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Bulk updates the class sessions.  This action requires authentication.
		/// </summary>
		/// <param name="@classid">The id of the class to bulk update.</param>
		/// <param name="@sessions">A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.</param>


		public static ActionResult Bulkupdate(Guid @classid, string @sessions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "session.bulkupdate", new {@classid, @sessions
});
		}

		

	}
}


