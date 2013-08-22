using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="@workshop">The id of the workshop whose swipe has to be saved.</param>
		/// <param name="@device">The unique id of the device whose swipe has to be saved.</param>


		public static ActionResult Save(DateTime @time, AttendanceType @type, Guid @workshop, string @device
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "swipe.save", new {@time, @type, @workshop, @device
});
		}

		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log
		/// </summary>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="@workshop">The id of the workshop whose swipe has to be saved.</param>
		/// <param name="@device">The unique id of the device whose swipe has to be saved.</param>
		/// <param name="@card">The id of the swipped card.</param>
		/// <param name="@cardnumber">The number of the swipped card, used if the id was not specified.</param>
		/// <param name="@room">The id of the room whose swipe has to be saved.</param>
		/// <param name="@devicename">The name of the device whose swipe has to be saved.</param>
		/// <param name="@metadata">The swipe's metadata in JSON format.</param>


		public static ActionResult Save(DateTime @time, AttendanceType @type, Guid @workshop, string @device, Guid @card, string @cardnumber, Guid @room, string @devicename, string @metadata
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "swipe.save", new {@time, @type, @workshop, @device, @card, @cardnumber, @room, @devicename, @metadata
});
		}

		

	}
}


