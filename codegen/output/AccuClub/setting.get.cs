using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Gets settings for the account.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>


		public static ActionResult Get(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "setting.get", new {@keys
});
		}

		
		/// <summary>
		/// Gets settings for the account
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>
		/// <param name="@domain">The account domain, in case of reading settings annonymously.</param>


		public static ActionResult Get(string @keys, string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "setting.get", new {@keys, @domain
});
		}

		

	}
}


