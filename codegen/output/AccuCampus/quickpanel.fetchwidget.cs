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
		/// Fetches the information for a specific widget..  This action requires authentication.
		/// </summary>
		/// <param name="@widgetid">The ID of the data to fetch it's data.</param>


		public static ActionResult Fetchwidget(Guid @widgetid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.fetchwidget", new {@widgetid
});
		}

		

	}
}


