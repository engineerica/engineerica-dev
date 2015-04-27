using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// Saves the settings for session registration..  This action requires authentication.
		/// </summary>


		public static ActionResult Savesettings(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "sessionreg.savesettings", new {
});
		}

		
		/// <summary>
		/// Saves the settings for session registration.
		/// </summary>
		/// <param name="@locationid">The id of the location to save settings.</param>
		/// <param name="@eventid">The id of the event to save settings.</param>
		/// <param name="@sessiondate">The date and time when the session starts.</param>
		/// <param name="@enabled">Whether the registration is enabled or not.</param>
		/// <param name="@capacity">The capacity of the class.</param>
		/// <param name="@trainerid">The trainer ID.</param>


		public static ActionResult Savesettings(Guid @locationid, Guid @eventid, DateTime @sessiondate, bool @enabled, int @capacity, Guid @trainerid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "sessionreg.savesettings", new {@locationid, @eventid, @sessiondate, @enabled, @capacity, @trainerid
});
		}

		

	}
}


