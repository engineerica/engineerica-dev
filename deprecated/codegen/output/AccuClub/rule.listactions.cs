using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Rules.
	/// </summary>
	public static partial class Rule
	{
		
		/// <summary>
		/// List rules actions available.  This action requires authentication.
		/// </summary>


		public static ActionResult Listactions(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "rule.listactions", new {
});
		}

		

	}
}


