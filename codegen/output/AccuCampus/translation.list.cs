using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Translations.
	/// </summary>
	public static partial class Translation
	{
		
		/// <summary>
		/// Lists all the available translations in the system.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "translation.list", new {
});
		}

		
		/// <summary>
		/// Lists all the available translations in the system
		/// </summary>
		/// <param name="@filter">Text to search/filter translations.</param>
		/// <param name="@nondefaultonly">If true then it returns only the terms translated. Otherwise, it returns all.</param>
		/// <param name="@appdefaultasuniversal">If true then it uses the app default translation as the universal term.</param>


		public static ActionResult List(string @filter, bool @nondefaultonly, bool @appdefaultasuniversal
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "translation.list", new {@filter, @nondefaultonly, @appdefaultasuniversal
});
		}

		

	}
}


