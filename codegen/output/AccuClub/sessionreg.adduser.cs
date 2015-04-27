using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// Adds a user to an event session.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to add.</param>
		/// <param name="@eventid">The id of the event.</param>
		/// <param name="@sessiondate">The date and time when the session starts.</param>


		public static ActionResult Adduser(Guid @userid, Guid @eventid, DateTime @sessiondate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "sessionreg.adduser", new {@userid, @eventid, @sessiondate
});
		}

		

	}
}


