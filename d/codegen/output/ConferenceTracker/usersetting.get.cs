using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Usersettings.
	/// </summary>
	public static partial class Usersetting
	{
		
		/// <summary>
		/// Gets user settings.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>


		public static ActionResult Get(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "usersetting.get", new {@keys
});
		}

		

	}
}


