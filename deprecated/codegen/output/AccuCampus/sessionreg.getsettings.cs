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
		/// Get the settings for session registration.  This action requires authentication.
		/// </summary>


		public static ActionResult Getsettings(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.getsettings", new {
});
		}

		
		/// <summary>
		/// Get the settings for session registration
		/// </summary>
		/// <param name="@locationid">The id of the location to save settings.</param>
		/// <param name="@eventid">The id of the event to save settings.</param>
		/// <param name="@sessiondate">The date and time when the session starts.</param>
		/// <param name="@noinherit">True to get the location/event/session specific settings without looking for the more global settings.</param>


		public static ActionResult Getsettings(Guid @locationid, Guid @eventid, DateTime @sessiondate, bool @noinherit
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.getsettings", new {@locationid, @eventid, @sessiondate, @noinherit
});
		}

		

	}
}


