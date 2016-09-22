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
		/// View the event registrations of the current user.  This action requires authentication.
		/// </summary>
		/// <param name="@listname">The name of the list where the user is registered.</param>


		public static ActionResult Getmyevents(string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getmyevents", new {@listname
});
		}

		
		/// <summary>
		/// View the event registrations of the current user
		/// </summary>
		/// <param name="@listname">The name of the list where the user is registered.</param>
		/// <param name="@termid">The term id to list events.</param>


		public static ActionResult Getmyevents(string @listname, Guid @termid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getmyevents", new {@listname, @termid
});
		}

		

	}
}


