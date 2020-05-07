using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Gets the top attendees sorted by .  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Topattendees(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.topattendees", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the top attendees sorted by 
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference whose leads have to be returned.</param>


		public static ActionResult Topattendees(int @from, int @count, Guid @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.topattendees", new {@from, @count, @conference
});
		}

		

	}
}


