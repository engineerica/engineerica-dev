using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Saves setting(s) for the current account.  This action requires authentication.
		/// </summary>
		/// <param name="@optionsjson">The options to save in the account, in JSON format.</param>


		public static ActionResult Save(string @optionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "setting.save", new {@optionsjson
});
		}

		

	}
}


