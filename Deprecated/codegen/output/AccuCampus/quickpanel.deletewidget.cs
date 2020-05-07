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
		/// Deletes a widget from the home page.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the widget.</param>


		public static ActionResult Deletewidget(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.deletewidget", new {@id
});
		}

		

	}
}


