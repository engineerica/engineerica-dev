using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Gets the swipes of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "swipe.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the swipes of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference whose swipes have to be returned.</param>
		/// <param name="@onlyunresolved">True to filter by unresolved swipes. Defaults to false.</param>


		public static ActionResult List(int @from, int @count, Guid @conference, bool @onlyunresolved
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "swipe.list", new {@from, @count, @conference, @onlyunresolved
});
		}

		

	}
}


