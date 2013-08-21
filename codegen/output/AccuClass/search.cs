using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Searchs.
	/// </summary>
	public partial class Search : ActionSet
	{
		
		/// <summary>
		/// Search.  This action requires authentication.
		/// </summary>
		/// <param name="_query">The query to search for.</param>


		public ActionResult Execute(string _query
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "search", new {_query
});
		}

		

	}
}


