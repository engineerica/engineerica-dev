using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Removes a user from an event event.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to remove.</param>
		/// <param name="@eventid">The id of the event.</param>
		/// <param name="@listname">The name of the list where the user is registered.</param>


		public static ActionResult Removeuser(Guid @userid, Guid @eventid, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.removeuser", new {@userid, @eventid, @listname
});
		}

		

	}
}


