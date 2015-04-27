using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Adds a user to an event event.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to add.</param>
		/// <param name="@eventid">The id of the event.</param>
		/// <param name="@listname">The name of the list where the user has to be registered.</param>


		public static ActionResult Adduser(Guid @userid, Guid @eventid, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.adduser", new {@userid, @eventid, @listname
});
		}

		

	}
}


