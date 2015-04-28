using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Events.
	/// </summary>
	public static partial class Event
	{
		
		/// <summary>
		/// Get event.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the event to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "event.get", new {@id
});
		}

		

	}
}


