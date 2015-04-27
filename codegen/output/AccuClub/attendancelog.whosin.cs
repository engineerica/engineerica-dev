using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance logs of the users that are signed-in.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Whosin(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "attendancelog.whosin", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the attendance logs of the users that are signed-in
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@location">The id of the location to search for users that are in.</param>
		/// <param name="@event">The id of the event to search for users that are in.</param>


		public static ActionResult Whosin(int @from, int @count, Guid @location, Guid @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "attendancelog.whosin", new {@from, @count, @location, @event
});
		}

		

	}
}


