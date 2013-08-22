using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Rooms.
	/// </summary>
	public static partial class Room
	{
		
		/// <summary>
		/// Get room.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the room to get.</param>


		public static ActionResult Get(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "room.get", new {@id
});
		}

		

	}
}


