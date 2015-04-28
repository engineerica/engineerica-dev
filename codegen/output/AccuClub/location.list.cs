using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Locations.
	/// </summary>
	public static partial class Location
	{
		
		/// <summary>
		/// Gets the location of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "location.list", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the location of the specified conference
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@locations">The comma-separated list containing the ids of the locations to list.</param>


		public static ActionResult List(int @from, int @count, int @locations
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "location.list", new {@from, @count, @locations
});
		}

		

	}
}


