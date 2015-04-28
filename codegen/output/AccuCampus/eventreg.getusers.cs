using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Lists the registrations at a specific event.  This action requires authentication.
		/// </summary>
		/// <param name="@eventid">The event id to list users.</param>
		/// <param name="@listname">The name of the list to get.</param>


		public static ActionResult Getusers(Guid @eventid, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getusers", new {@eventid, @listname
});
		}

		

	}
}


