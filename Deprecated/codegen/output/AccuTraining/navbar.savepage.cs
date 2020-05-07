using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Navbars.
	/// </summary>
	public static partial class Navbar
	{
		
		/// <summary>
		/// Adds a page to be listed in the navigation bar.  This action requires authentication.
		/// </summary>
		/// <param name="@title">Title of the page.</param>
		/// <param name="@link">Link to the page to list.</param>
		/// <param name="@sortorder">The sort order of the link.</param>


		public static ActionResult Savepage(string @title, string @link, int @sortorder
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "navbar.savepage", new {@title, @link, @sortorder
});
		}

		
		/// <summary>
		/// Adds a page to be listed in the navigation bar
		/// </summary>
		/// <param name="@title">Title of the page.</param>
		/// <param name="@link">Link to the page to list.</param>
		/// <param name="@sortorder">The sort order of the link.</param>
		/// <param name="@id">The id of the link.</param>
		/// <param name="@roleids">CSV list of roles that display this link.</param>


		public static ActionResult Savepage(string @title, string @link, int @sortorder, Guid @id, string @roleids
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "navbar.savepage", new {@title, @link, @sortorder, @id, @roleids
});
		}

		

	}
}


