using System;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "rule.listeventtypes", new {
});
		}

		

	}
}


