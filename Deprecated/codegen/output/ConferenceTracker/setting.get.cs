using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Gets setting(s) for a specific conference.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>


		public static ActionResult Get(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.get", new {@keys
});
		}

		
		/// <summary>
		/// Gets setting(s) for a specific conference
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>
		/// <param name="@domain">The account domain, in case of reading settings annonymously.</param>


		public static ActionResult Get(string @keys, string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.get", new {@keys, @domain
});
		}

		

	}
}


