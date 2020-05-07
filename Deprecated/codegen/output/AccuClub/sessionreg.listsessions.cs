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
		/// List the sessions available for a specific event.  This action requires authentication.
		/// </summary>
		/// <param name="@eventid">The event id to list sessions.</param>


		public static ActionResult Listsessions(Guid @eventid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "sessionreg.listsessions", new {@eventid
});
		}

		
		/// <summary>
		/// List the sessions available for a specific event
		/// </summary>
		/// <param name="@eventid">The event id to list sessions.</param>
		/// <param name="@sessiondate">The date of the session to find.</param>


		public static ActionResult Listsessions(Guid @eventid, DateTime @sessiondate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "sessionreg.listsessions", new {@eventid, @sessiondate
});
		}

		

	}
}


