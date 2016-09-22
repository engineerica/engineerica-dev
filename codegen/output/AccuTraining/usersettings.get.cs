using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usersettingss.
	/// </summary>
	public static partial class Usersettings
	{
		
		/// <summary>
		/// Lists available user settings.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">Setting key to get. Can be multiple separated by commas.</param>


		public static ActionResult Get(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usersettings.get", new {@keys
});
		}

		
		/// <summary>
		/// Lists available user settings
		/// </summary>
		/// <param name="@keys">Setting key to get. Can be multiple separated by commas.</param>
		/// <param name="@user">The user id whose settings have to be returned.</param>


		public static ActionResult Get(string @keys, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usersettings.get", new {@keys, @user
});
		}

		

	}
}


