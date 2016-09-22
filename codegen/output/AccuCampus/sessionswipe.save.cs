using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionswipes.
	/// </summary>
	public static partial class Sessionswipe
	{
		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="@client">The unique id of the client whose swipe has to be saved.</param>


		public static ActionResult Save(AttendanceType @type, string @client
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionswipe.save", new {@type, @client
});
		}

		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log
		/// </summary>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="@client">The unique id of the client whose swipe has to be saved.</param>
		/// <param name="@time">The date and time of the swipe. Now is considered if omitted.</param>
		/// <param name="@cardnumber">The number of the swipped card, used if the id was not specified.</param>
		/// <param name="@session">The id of the session whose swipe has to be saved.</param>
		/// <param name="@location">The id of the location whose swipe has to be saved.</param>
		/// <param name="@clientname">The name of the client whose swipe has to be saved.</param>
		/// <param name="@metadata">The swipe's metadata in JSON format.</param>
		/// <param name="@photosize">The swiping user's photo size.</param>


		public static ActionResult Save(AttendanceType @type, string @client, DateTime @time, string @cardnumber, Guid @session, Guid @location, string @clientname, string @metadata, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionswipe.save", new {@type, @client, @time, @cardnumber, @session, @location, @clientname, @metadata, @photosize
});
		}

		

	}
}


