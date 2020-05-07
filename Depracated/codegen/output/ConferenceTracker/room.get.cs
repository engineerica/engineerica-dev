using System;

namespace EngineericaApi.ConferenceTracker
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


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "room.get", new {@id
});
		}

		

	}
}


