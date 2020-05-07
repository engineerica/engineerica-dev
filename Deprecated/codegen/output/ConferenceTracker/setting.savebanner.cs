using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Saves the conference banner.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Savebanner(string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.savebanner", new {@upload
});
		}

		
		/// <summary>
		/// Saves the conference banner
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>


		public static ActionResult Savebanner(string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "setting.savebanner", new {@upload, @filename
});
		}

		

	}
}


