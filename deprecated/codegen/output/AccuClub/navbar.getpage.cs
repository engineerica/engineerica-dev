using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Navbars.
	/// </summary>
	public static partial class Navbar
	{
		
		/// <summary>
		/// View a page included in the navigation bar.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the page to get.</param>


		public static ActionResult Getpage(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "navbar.getpage", new {@id
});
		}

		

	}
}


