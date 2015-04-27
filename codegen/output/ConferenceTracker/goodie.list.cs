using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Goodies.
	/// </summary>
	public static partial class Goodie
	{
		
		/// <summary>
		/// Gets the handouts of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "goodie.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the handouts of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@conference">The id of the conference whose handouts have to be returned.</param>


		public static ActionResult List(int @from, int @count, Guid @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "goodie.list", new {@from, @count, @conference
});
		}

		

	}
}


