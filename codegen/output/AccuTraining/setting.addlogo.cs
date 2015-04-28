using System;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "setting.addlogo", new {@upload, @filename
});
		}

		

	}
}


