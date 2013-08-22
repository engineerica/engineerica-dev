using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Saves setting(s) for a specific conference.  This action requires authentication.
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>


		public static ActionResult Save(string @optionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.save", new {@optionsjson
});
		}

		

	}
}


