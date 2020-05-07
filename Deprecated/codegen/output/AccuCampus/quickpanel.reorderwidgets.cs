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
		/// Reorders the widgets and moves them to a specific column.  This action requires authentication.
		/// </summary>
		/// <param name="@sectionname">The section name where to sort the widgets.</param>
		/// <param name="@orderids">CSV list of the widgets to reorder.</param>


		public static ActionResult Reorderwidgets(string @sectionname, string @orderids
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.reorderwidgets", new {@sectionname, @orderids
});
		}

		

	}
}


