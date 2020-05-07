using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// Logged user can un-register himself from an event session.  This action requires authentication.
		/// </summary>
		/// <param name="@eventid">The id of the event.</param>
		/// <param name="@sessiondate">The date and time when the session starts.</param>


		public static ActionResult Removecurrentuser(Guid @eventid, DateTime @sessiondate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.removecurrentuser", new {@eventid, @sessiondate
});
		}

		

	}
}


