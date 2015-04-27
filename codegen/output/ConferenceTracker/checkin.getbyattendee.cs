using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Checkins.
	/// </summary>
	public static partial class Checkin
	{
		
		/// <summary>
		/// Get check-in.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference related to the check-in that has to be retrieved.</param>
		/// <param name="@attendee">The id of the attendee whose check-in has to be retrieved.</param>


		public static ActionResult Getbyattendee(Guid @conference, Guid @attendee
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "checkin.getbyattendee", new {@conference, @attendee
});
		}

		

	}
}


