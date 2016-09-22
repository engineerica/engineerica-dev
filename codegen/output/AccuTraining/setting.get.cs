using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Get settings for the account or the specified scope.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>


		public static ActionResult Get(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "setting.get", new {@keys
});
		}

		
		/// <summary>
		/// Get settings for the account or the specified scope
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>
		/// <param name="@domain">The account domain, in case of reading settings annonymously.</param>
		/// <param name="@scope">The scope of the settings to get.</param>


		public static ActionResult Get(string @keys, string @domain, string @scope
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "setting.get", new {@keys, @domain, @scope
});
		}

		

	}
}


