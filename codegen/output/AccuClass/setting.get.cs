using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public partial class Setting : ActionSet
	{
		
		/// <summary>
		/// Gets setting(s) for the account.  This action requires authentication.
		/// </summary>
		/// <param name="_keys">The option keys to get values for. Enter multiple separated by comma.</param>


		public ActionResult Get(string _keys
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "setting.get", new {_keys
});
		}

		

	}
}


