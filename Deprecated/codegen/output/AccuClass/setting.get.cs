using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Settings.
	/// </summary>
	public static partial class Setting
	{
		
		/// <summary>
		/// Gets setting(s) for the account.  This action requires authentication.
		/// </summary>
		/// <param name="@keys">The option keys to get values for. Enter multiple separated by comma.</param>


		public static ActionResult Get(string @keys
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "setting.get", new {@keys
});
		}

		

	}
}


