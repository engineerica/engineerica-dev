using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshops.
	/// </summary>
	public static partial class Workshop
	{
		
		/// <summary>
		/// Gets the workshops of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(string @from, string @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the workshops of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference whose workshops have to be returned. If not specified the 'next' conference will be used.</param>
		/// <param name="@date">Filter the session for a specific date.</param>
		/// <param name="@speaker">Filter the sessions by speaker. Match is exact.</param>
		/// <param name="@roomid">Filter the session by room ID.</param>
		/// <param name="@now">True to return only workshops that are happening 'now'. Defaults to false.</param>


		public static ActionResult List(string @from, string @count, string @conference, DateTime @date, string @speaker, Guid @roomid, bool @now
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.list", new {@from, @count, @conference, @date, @speaker, @roomid, @now
});
		}

		

	}
}


