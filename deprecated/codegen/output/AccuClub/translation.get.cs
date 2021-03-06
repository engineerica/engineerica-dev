using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Translations.
	/// </summary>
	public static partial class Translation
	{
		
		/// <summary>
		/// Gets the translations of the specified values.  This action requires authentication.
		/// </summary>
		/// <param name="@universal">Pipe separated list of universal text to be translated.</param>


		public static ActionResult Get(string @universal
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "translation.get", new {@universal
});
		}

		

	}
}


