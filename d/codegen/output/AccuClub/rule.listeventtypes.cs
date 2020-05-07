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
		/// List rule event types.  This action requires authentication.
		/// </summary>


		public static ActionResult Listeventtypes(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "rule.listeventtypes", new {
});
		}

		

	}
}


