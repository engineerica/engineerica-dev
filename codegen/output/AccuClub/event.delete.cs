using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Events.
	/// </summary>
	public static partial class Event
	{
		
		/// <summary>
		/// Deletes a event.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the event to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "event.delete", new {@id
});
		}

		

	}
}


