using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Quickpanels.
	/// </summary>
	public static partial class Quickpanel
	{
		
		/// <summary>
		/// View a page included in the navigation bar.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the widget to get.</param>


		public static ActionResult Getwidget(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.getwidget", new {@id
});
		}

		

	}
}


