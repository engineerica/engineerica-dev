using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Saves settings for the account.  This action requires authentication.
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>


		public static ActionResult Save(string @optionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "setting.save", new {@optionsjson
});
		}

		

	}
}


