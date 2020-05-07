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
		/// Save multiple user settings at once.  This action requires authentication.
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>


		public static ActionResult Savemultiple(string @optionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "usersettings.savemultiple", new {@optionsjson
});
		}

		
		/// <summary>
		/// Save multiple user settings at once
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>
		/// <param name="@user">The user id whose settings have to be saved.</param>


		public static ActionResult Savemultiple(string @optionsjson, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "usersettings.savemultiple", new {@optionsjson, @user
});
		}

		

	}
}


