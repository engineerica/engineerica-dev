using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Bulk updates the event sessions.  This action requires authentication.
		/// </summary>
		/// <param name="@eventid">The id of the event to bulk update.</param>
		/// <param name="@sessions">A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.</param>


		public static ActionResult Bulkupdate(Guid @eventid, string @sessions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "session.bulkupdate", new {@eventid, @sessions
});
		}

		

	}
}


