using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Adds a logo to the account.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The original filename, needed to process the file.</param>


		public static ActionResult Addlogo(string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "setting.addlogo", new {@upload, @filename
});
		}

		

	}
}


