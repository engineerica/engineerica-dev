using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Usersettings.
	/// </summary>
	public static partial class Usersetting
	{
		
		/// <summary>
		/// Saves user settings.  This action requires authentication.
		/// </summary>
		/// <param name="@optionsjson">The options to save for the current user, in JSON format.</param>


		public static ActionResult Save(string @optionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "usersetting.save", new {@optionsjson
});
		}

		

	}
}


