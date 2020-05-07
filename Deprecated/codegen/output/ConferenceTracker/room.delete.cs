using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Rooms.
	/// </summary>
	public static partial class Room
	{
		
		/// <summary>
		/// Deletes a room.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the room to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "room.delete", new {@id
});
		}

		

	}
}


