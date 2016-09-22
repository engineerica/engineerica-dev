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
		/// Save the settings for session registration.  This action requires authentication.
		/// </summary>


		public static ActionResult Savesettings(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.savesettings", new {
});
		}

		
		/// <summary>
		/// Save the settings for session registration
		/// </summary>
		/// <param name="@locationid">The id of the location to save settings.</param>
		/// <param name="@eventid">The id of the event to save settings.</param>
		/// <param name="@sessiondate">The date and time when the session starts.</param>
		/// <param name="@enabled">Whether the registration is enabled or not.</param>
		/// <param name="@capacity">The capacity of the class.</param>
		/// <param name="@trainerid">The trainer ID.</param>
		/// <param name="@showupcomingdays"># of days to show upcoming sessions</param>
		/// <param name="@registernolessdurationbasis">Specifies the time unit of measurement to restrict the period when attendees can register to sessions (no less than 0 = Minutes, 1 = Hours, 2 = Days, 3 = Weeks).</param>
		/// <param name="@registernolessduration">Specifies the duration of the period when attendees can register to sessions (no less than the specified magnitude).</param>
		/// <param name="@registernomoredurationbasis">Specifies the time unit of measurement to restrict the period when attendees can register to sessions (no more than 0 = Minutes, 1 = Hours, 2 = Days, 3 = Weeks).</param>
		/// <param name="@registernomoreduration">Specifies the duration of the period when attendees can register to sessions (no more than the specified magnitude).</param>
		/// <param name="@unregisternolessdurationbasis">Specifies the time unit of measurement to restrict the period when attendees can unregister from sessions (no less than 0 = Minutes, 1 = Hours, 2 = Days, 3 = Weeks).</param>
		/// <param name="@unregisternolessduration">Specifies the duration of the period when attendees can unregister from sessions (no less than the specified magnitude).</param>


		public static ActionResult Savesettings(Guid @locationid, Guid @eventid, DateTime @sessiondate, bool @enabled, int @capacity, Guid @trainerid, int @showupcomingdays, DurationBasis @registernolessdurationbasis, int @registernolessduration, DurationBasis @registernomoredurationbasis, int @registernomoreduration, DurationBasis @unregisternolessdurationbasis, int @unregisternolessduration
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.savesettings", new {@locationid, @eventid, @sessiondate, @enabled, @capacity, @trainerid, @showupcomingdays, @registernolessdurationbasis, @registernolessduration, @registernomoredurationbasis, @registernomoreduration, @unregisternolessdurationbasis, @unregisternolessduration
});
		}

		

	}
}


