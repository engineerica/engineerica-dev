using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Sessionsurveys.
	/// </summary>
	public static partial class Sessionsurvey
	{
		
		/// <summary>
		/// Saves the attendee responses to a session evaluation survey.  This action requires authentication.
		/// </summary>
		/// <param name="@sessionid">The ID of the session being evaluated.</param>
		/// <param name="@ratings">JSON array containing the list of answers, with Id (of the question) and Rate (int).</param>


		public static ActionResult Rate(Guid @sessionid, string @ratings
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "sessionsurvey.rate", new {@sessionid, @ratings
});
		}

		
		/// <summary>
		/// Saves the attendee responses to a session evaluation survey
		/// </summary>
		/// <param name="@sessionid">The ID of the session being evaluated.</param>
		/// <param name="@ratings">JSON array containing the list of answers, with Id (of the question) and Rate (int).</param>
		/// <param name="@comments">Comments to add to this session.</param>


		public static ActionResult Rate(Guid @sessionid, string @ratings, string @comments
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "sessionsurvey.rate", new {@sessionid, @ratings, @comments
});
		}

		

	}
}


