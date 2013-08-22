using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Rooms.
	/// </summary>
	public static partial class Room
	{
		
		/// <summary>
		/// Saves room.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the room.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "room.save", new {@name
});
		}

		
		/// <summary>
		/// Saves room
		/// </summary>
		/// <param name="@name">The name of the room.</param>
		/// <param name="@id">The id of the room to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "room.save", new {@name, @id
});
		}

		

	}
}


