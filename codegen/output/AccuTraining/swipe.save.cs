using System;

namespace EngineericaApi.AccuTraining
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
		/// <param name="@cardnumber">The number of the swipped card.</param>
		/// <param name="@client">The unique id of the client whose swipe has to be saved.</param>


		public static ActionResult Save(DateTime @time, string @cardnumber, string @client
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "swipe.save", new {@time, @cardnumber, @client
});
		}

		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log
		/// </summary>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@cardnumber">The number of the swipped card.</param>
		/// <param name="@client">The unique id of the client whose swipe has to be saved.</param>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out). If not specified then it's inferred from existing logs.</param>
		/// <param name="@location">The id of the location whose swipe has to be saved.</param>
		/// <param name="@event">The id of the event whose swipe has to be saved.</param>
		/// <param name="@clientname">The name of the client whose swipe has to be saved.</param>
		/// <param name="@metadata">The swipe's metadata in JSON format.</param>
		/// <param name="@photosize">The swiping user's photo size.</param>


		public static ActionResult Save(DateTime @time, string @cardnumber, string @client, AttendanceType @type, Guid @location, Guid @event, string @clientname, string @metadata, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "swipe.save", new {@time, @cardnumber, @client, @type, @location, @event, @clientname, @metadata, @photosize
});
		}

		

	}
}


