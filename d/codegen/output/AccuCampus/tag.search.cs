using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Tags.
	/// </summary>
	public static partial class Tag
	{
		
		/// <summary>
		/// Search for tags in the account.  This action requires authentication.
		/// </summary>
		/// <param name="@query">The query to search tags. Use group:<group> to search in a specific group (mandatory).</param>


		public static ActionResult Search(string @query
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "tag.search", new {@query
});
		}

		
		/// <summary>
		/// Search for tags in the account
		/// </summary>
		/// <param name="@query">The query to search tags. Use group:<group> to search in a specific group (mandatory).</param>
		/// <param name="@allowcreatingnew">Specifies whether an option to create a new tag should be retrieved.</param>


		public static ActionResult Search(string @query, bool @allowcreatingnew
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "tag.search", new {@query, @allowcreatingnew
});
		}

		

	}
}


