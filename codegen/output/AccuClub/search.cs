using System;

namespace EngineericaApi.AccuClub
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "search", new {@query
});
		}

		
		/// <summary>
		/// Search
		/// </summary>
		/// <param name="@query">The query to search for.</param>
		/// <param name="@page">Current page to show, zero-based.</param>


		public static ActionResult Execute(string @query, int @page
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "search", new {@query, @page
});
		}

		

	}
}


