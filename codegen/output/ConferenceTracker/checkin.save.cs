using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Checkins.
	/// </summary>
	public static partial class Checkin
	{
		
		/// <summary>
		/// Saves a check-in.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference related to the check-in that has to be saved.</param>
		/// <param name="@attendee">The attende that is checking-in.</param>


		public static ActionResult Save(Guid @conference, Guid @attendee
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "checkin.save", new {@conference, @attendee
});
		}

		
		/// <summary>
		/// Saves a check-in
		/// </summary>
		/// <param name="@conference">The id of the conference related to the check-in that has to be saved.</param>
		/// <param name="@attendee">The attende that is checking-in.</param>
		/// <param name="@deliveredgoodies">The list of the ids of the delivered handouts, splitted by a pipe.</param>
		/// <param name="@notes">The notes of the check-in.</param>


		public static ActionResult Save(Guid @conference, Guid @attendee, string @deliveredgoodies, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "checkin.save", new {@conference, @attendee, @deliveredgoodies, @notes
});
		}

		

	}
}


