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
		/// <param name="@userid">Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.</param>
		/// <param name="@excludezerocredit">True to create certificates only for those with credit. Defaults to false.</param>
		/// <param name="@forsending">It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading</param>
		/// <param name="@onlymodifiedafter">When printing all badges, print only those modified after a certain date.</param>
		/// <param name="@role">When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor</param>


		public static ActionResult Create(string @conference, bool @singlefile, string @kind, string @userid, bool @excludezerocredit, bool @forsending, DateTime @onlymodifiedafter, string @role
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.create", new {@conference, @singlefile, @kind, @userid, @excludezerocredit, @forsending, @onlymodifiedafter, @role
});
		}

		

	}
}


