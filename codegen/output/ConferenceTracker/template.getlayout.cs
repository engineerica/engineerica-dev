using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Gets template's layout for a conference.  This action requires authentication.
		/// </summary>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>


		public static ActionResult Getlayout(string @kind
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.getlayout", new {@kind
});
		}

		
		/// <summary>
		/// Gets template's layout for a conference
		/// </summary>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>
		/// <param name="@conference">The id of the conference whose template layout has to be saved.</param>


		public static ActionResult Getlayout(string @kind, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.getlayout", new {@kind, @conference
});
		}

		

	}
}


