using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public partial class Setting : ActionSet
	{
		
		/// <summary>
		/// Saves setting(s) for the current account.  This action requires authentication.
		/// </summary>
		/// <param name="_optionsjson">The options to save in the account, in JSON format.</param>


		public ActionResult Save(string _optionsjson
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "setting.save", new {_optionsjson
});
		}

		

	}
}


