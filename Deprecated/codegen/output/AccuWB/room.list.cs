using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Rooms.
	/// </summary>
	public static partial class Room
	{
		
		/// <summary>
		/// Gets the rooms.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "room.list", new {@from, @count
});
		}

		

	}
}


