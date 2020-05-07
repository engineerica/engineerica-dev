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
		/// Saves a user setting.  This action requires authentication.
		/// </summary>
		/// <param name="@key">Setting key to save.</param>
		/// <param name="@value">Setting value to save.</param>


		public static ActionResult Save(string @key, string @value
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usersettings.save", new {@key, @value
});
		}

		
		/// <summary>
		/// Saves a user setting
		/// </summary>
		/// <param name="@key">Setting key to save.</param>
		/// <param name="@value">Setting value to save.</param>
		/// <param name="@user">The user id whose settings have to be saved.</param>


		public static ActionResult Save(string @key, string @value, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usersettings.save", new {@key, @value, @user
});
		}

		

	}
}


