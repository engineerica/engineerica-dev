using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "event.searchgroup", new {@query
});
		}

		

	}
}


