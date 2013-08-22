using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Creates conference templates..  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference whose templates must be created.</param>
		/// <param name="@singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>


		public static ActionResult Create(string @conference, bool @singlefile, string @kind
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.create", new {@conference, @singlefile, @kind
});
		}

		
		/// <summary>
		/// Creates conference templates.
		/// </summary>
		/// <param name="@conference">The id of the conference whose templates must be created.</param>
		/// <param name="@singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>
		/// <param name="@attendeeid">Only the template for these attendees is created (and emailed if 'email' is true), enter multiple separated by commas.</param>


		public static ActionResult Create(string @conference, bool @singlefile, string @kind, string @attendeeid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.create", new {@conference, @singlefile, @kind, @attendeeid
});
		}

		

	}
}


