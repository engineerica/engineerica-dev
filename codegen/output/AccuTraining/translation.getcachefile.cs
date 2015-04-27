using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Translations.
	/// </summary>
	public static partial class Translation
	{
		
		/// <summary>
		/// Get the file containing the translations.  This action requires authentication.
		/// </summary>


		public static ActionResult Getcachefile(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "translation.getcachefile", new {
});
		}

		
		/// <summary>
		/// Get the file containing the translations
		/// </summary>
		/// <param name="@account">The id of the account whose translations file has to be retrieved.</param>


		public static ActionResult Getcachefile(string @account
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "translation.getcachefile", new {@account
});
		}

		

	}
}


