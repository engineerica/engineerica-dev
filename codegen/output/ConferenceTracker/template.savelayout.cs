using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Saves template's layout for a conference.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference whose template layout has to be saved.</param>
		/// <param name="@layout">The template's layout (in JSON).</param>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>


		public static ActionResult Savelayout(string @conference, string @layout, string @kind
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.savelayout", new {@conference, @layout, @kind
});
		}

		

	}
}


