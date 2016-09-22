using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Lists newsletters and the status of the newsletter.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.list", new {
});
		}

		
		/// <summary>
		/// Lists newsletters and the status of the newsletter
		/// </summary>
		/// <param name="@notsentonly">True to return only the ones that have not been sent yet.</param>


		public static ActionResult List(bool @notsentonly
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.list", new {@notsentonly
});
		}

		

	}
}


