using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Lists the event registrations of a specific user.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The user id to list events.</param>
		/// <param name="@listname">The name of the list where the user is registered.</param>


		public static ActionResult Getevents(Guid @userid, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getevents", new {@userid, @listname
});
		}

		
		/// <summary>
		/// Lists the event registrations of a specific user
		/// </summary>
		/// <param name="@userid">The user id to list events.</param>
		/// <param name="@listname">The name of the list where the user is registered.</param>
		/// <param name="@termid">The term id to list events.</param>


		public static ActionResult Getevents(Guid @userid, string @listname, Guid @termid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getevents", new {@userid, @listname, @termid
});
		}

		

	}
}


