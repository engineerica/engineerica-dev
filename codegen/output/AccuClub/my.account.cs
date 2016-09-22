using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Returns the logged user's account..  This action requires authentication.
		/// </summary>


		public static ActionResult Account(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "my.account", new {
});
		}

		

	}
}


