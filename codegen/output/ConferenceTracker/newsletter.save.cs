using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Saves a newsletter.  This action requires authentication.
		/// </summary>
		/// <param name="@senddate">Date to send the newsletter.</param>


		public static ActionResult Save(DateTime @senddate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.save", new {@senddate
});
		}

		
		/// <summary>
		/// Saves a newsletter
		/// </summary>
		/// <param name="@senddate">Date to send the newsletter.</param>
		/// <param name="@id">Id of the newsletter to save.</param>


		public static ActionResult Save(DateTime @senddate, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.save", new {@senddate, @id
});
		}

		

	}
}


