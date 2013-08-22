using System;

namespace EngineericaApi.ConferenceTracker
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
		/// <param name="@location">The location of the room.</param>
		/// <param name="@conference">The id of the conference whose room has to be saved.</param>


		public static ActionResult Save(string @name, string @location, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "room.save", new {@name, @location, @conference
});
		}

		
		/// <summary>
		/// Saves room
		/// </summary>
		/// <param name="@name">The name of the room.</param>
		/// <param name="@location">The location of the room.</param>
		/// <param name="@conference">The id of the conference whose room has to be saved.</param>
		/// <param name="@id">The id of the room to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, string @location, string @conference, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "room.save", new {@name, @location, @conference, @id
});
		}

		

	}
}


