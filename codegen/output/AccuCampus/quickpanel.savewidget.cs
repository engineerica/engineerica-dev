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
		/// Saves a widget for the home page.  This action requires authentication.
		/// </summary>
		/// <param name="@sectionname">The section name where to add the widget.</param>
		/// <param name="@sortorder">The sort order of the widget.</param>
		/// <param name="@title">Title of the widget.</param>
		/// <param name="@type">Type of the widget.</param>
		/// <param name="@data">Context data of the widget.</param>
		/// <param name="@roleids">CSV list of roles that display this widget.</param>


		public static ActionResult Savewidget(string @sectionname, int @sortorder, string @title, string @type, string @data, string @roleids
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.savewidget", new {@sectionname, @sortorder, @title, @type, @data, @roleids
});
		}

		
		/// <summary>
		/// Saves a widget for the home page
		/// </summary>
		/// <param name="@sectionname">The section name where to add the widget.</param>
		/// <param name="@sortorder">The sort order of the widget.</param>
		/// <param name="@title">Title of the widget.</param>
		/// <param name="@type">Type of the widget.</param>
		/// <param name="@data">Context data of the widget.</param>
		/// <param name="@roleids">CSV list of roles that display this widget.</param>
		/// <param name="@id">The id of the widget.</param>


		public static ActionResult Savewidget(string @sectionname, int @sortorder, string @title, string @type, string @data, string @roleids, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.savewidget", new {@sectionname, @sortorder, @title, @type, @data, @roleids, @id
});
		}

		

	}
}


