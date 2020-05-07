using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshops.
	/// </summary>
	public static partial class Workshop
	{
		
		/// <summary>
		/// Lists the workshops speakers.  This action requires authentication.
		/// </summary>


		public static ActionResult Listspeakers(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.listspeakers", new {
});
		}

		
		/// <summary>
		/// Lists the workshops speakers
		/// </summary>
		/// <param name="@conference">The id of the conference whose speakers have to be returned. If not specified the 'next' conference will be used.</param>


		public static ActionResult Listspeakers(string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.listspeakers", new {@conference
});
		}

		

	}
}


