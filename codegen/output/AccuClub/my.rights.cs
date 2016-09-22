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
		/// Returns the list of actions that the user can execute..  This action requires authentication.
		/// </summary>


		public static ActionResult Rights(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "my.rights", new {
});
		}

		

	}
}


