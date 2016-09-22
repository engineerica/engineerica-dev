using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Easylogins.
	/// </summary>
	public static partial class Easylogin
	{
		
		/// <summary>
		/// Adds background image for the login.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The original filename, needed to process the file.</param>


		public static ActionResult Addbgimage(string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "easylogin.addbgimage", new {@upload, @filename
});
		}

		

	}
}


