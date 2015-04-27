using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Events.
	/// </summary>
	public static partial class Event
	{
		
		/// <summary>
		/// Gets and repairs events' sessions according to their schedule.  This action requires authentication.
		/// </summary>
		/// <param name="@eventid">The id of the event to check.</param>
		/// <param name="@autorepair">True to automatically fix the invalid sessions.</param>


		public static ActionResult Checksessions(Guid @eventid, bool @autorepair
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "event.checksessions", new {@eventid, @autorepair
});
		}

		

	}
}


