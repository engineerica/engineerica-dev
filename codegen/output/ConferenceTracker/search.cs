using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Searchs.
	/// </summary>
	public static partial class Search
	{
		
		/// <summary>
		/// Search.  This action requires authentication.
		/// </summary>
		/// <param name="@query">The query to search for.</param>


		public static ActionResult Execute(string @query
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "search", new {@query
});
		}

		

	}
}


