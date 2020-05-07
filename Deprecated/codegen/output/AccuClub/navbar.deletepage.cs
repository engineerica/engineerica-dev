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
		/// Deletes a page from the navigation bar.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the link.</param>


		public static ActionResult Deletepage(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "navbar.deletepage", new {@id
});
		}

		

	}
}


