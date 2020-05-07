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
		/// Lists the page that are included in the navigation bar.  This action requires authentication.
		/// </summary>


		public static ActionResult Listpages(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "navbar.listpages", new {
});
		}

		

	}
}


