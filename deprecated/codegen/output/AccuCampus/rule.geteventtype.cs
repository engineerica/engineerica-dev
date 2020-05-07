using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Rules.
	/// </summary>
	public static partial class Rule
	{
		
		/// <summary>
		/// Gets a rule event type.  This action requires authentication.
		/// </summary>
		/// <param name="@event">The name of the event to refresh.</param>


		public static ActionResult Geteventtype(string @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rule.geteventtype", new {@event
});
		}

		

	}
}


