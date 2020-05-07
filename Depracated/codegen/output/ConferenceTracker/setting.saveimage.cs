using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Saves an image as a setting for the account.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@settingkey">The key of the setting where the image name has to be saved.</param>


		public static ActionResult Saveimage(string @upload, string @settingkey
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.saveimage", new {@upload, @settingkey
});
		}

		
		/// <summary>
		/// Saves an image as a setting for the account
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@settingkey">The key of the setting where the image name has to be saved.</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>


		public static ActionResult Saveimage(string @upload, string @settingkey, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.saveimage", new {@upload, @settingkey, @filename
});
		}

		

	}
}


