using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Translations.
	/// </summary>
	public static partial class Translation
	{
		
		/// <summary>
		/// Saves translation.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the translation as returned by translation.list.</param>
		/// <param name="@translation">The translated text.</param>


		public static ActionResult Save(string @id, string @translation
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "translation.save", new {@id, @translation
});
		}

		

	}
}


