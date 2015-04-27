using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Tags.
	/// </summary>
	public static partial class Tag
	{
		
		/// <summary>
		/// Searches for tags in the account.  This action requires authentication.
		/// </summary>
		/// <param name="@query">The query to search tags. Use group:<group> to search in a specific group (mandatory).</param>


		public static ActionResult Search(string @query
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "tag.search", new {@query
});
		}

		

	}
}


