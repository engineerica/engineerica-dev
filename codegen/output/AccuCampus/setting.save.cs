using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Save settings for the account or the specified scope.  This action requires authentication.
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>


		public static ActionResult Save(string @optionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "setting.save", new {@optionsjson
});
		}

		
		/// <summary>
		/// Save settings for the account or the specified scope
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>
		/// <param name="@scope">The scope of the settings to save.</param>


		public static ActionResult Save(string @optionsjson, string @scope
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "setting.save", new {@optionsjson, @scope
});
		}

		

	}
}


