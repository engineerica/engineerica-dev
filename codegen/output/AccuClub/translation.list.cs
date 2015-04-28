using System;

namespace EngineericaApi.AccuClub
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "translation.list", new {
});
		}

		
		/// <summary>
		/// Lists all the available translations in the system
		/// </summary>
		/// <param name="@filter">Text to search/filter translations.</param>


		public static ActionResult List(string @filter
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "translation.list", new {@filter
});
		}

		

	}
}


