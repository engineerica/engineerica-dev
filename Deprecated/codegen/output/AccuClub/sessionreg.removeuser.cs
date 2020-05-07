using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// Removes a user from an event session.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to remove.</param>
		/// <param name="@eventid">The id of the event.</param>
		/// <param name="@sessiondate">The date and time when the session starts.</param>


		public static ActionResult Removeuser(Guid @userid, Guid @eventid, DateTime @sessiondate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "sessionreg.removeuser", new {@userid, @eventid, @sessiondate
});
		}

		

	}
}


