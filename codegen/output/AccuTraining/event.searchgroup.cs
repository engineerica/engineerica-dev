using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Events.
	/// </summary>
	public static partial class Event
	{
		
		/// <summary>
		/// Searches for the available event groups.  This action requires authentication.
		/// </summary>
		/// <param name="@query">Query to search event groups.</param>


		public static ActionResult Searchgroup(Guid @query
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "event.searchgroup", new {@query
});
		}

		

	}
}


