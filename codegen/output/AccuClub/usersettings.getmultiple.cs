using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Usersettingss.
	/// </summary>
	public static partial class Usersettings
	{
		
		/// <summary>
		/// Get multiple user settings.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">Setting key to get. Can be multiple separated by commas.</param>


		public static ActionResult Getmultiple(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "usersettings.getmultiple", new {@keys
});
		}

		
		/// <summary>
		/// Get multiple user settings
		/// </summary>
		/// <param name="@keys">Setting key to get. Can be multiple separated by commas.</param>
		/// <param name="@user">The user id whose settings have to be returned.</param>


		public static ActionResult Getmultiple(string @keys, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "usersettings.getmultiple", new {@keys, @user
});
		}

		

	}
}


