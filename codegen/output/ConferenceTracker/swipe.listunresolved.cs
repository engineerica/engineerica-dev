using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Gets the swipes unresolved with additional info for quick resolve.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listunresolved(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "swipe.listunresolved", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the swipes unresolved with additional info for quick resolve
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference whose swipes have to be returned.</param>


		public static ActionResult Listunresolved(int @from, int @count, Guid @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "swipe.listunresolved", new {@from, @count, @conference
});
		}

		

	}
}


