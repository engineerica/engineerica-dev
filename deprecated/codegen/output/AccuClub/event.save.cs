using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Events.
	/// </summary>
	public static partial class Event
	{
		
		/// <summary>
		/// Saves an event.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the event.</param>
		/// <param name="@code">The unique code of the event.</param>


		public static ActionResult Save(string @name, string @code
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "event.save", new {@name, @code
});
		}

		
		/// <summary>
		/// Saves an event
		/// </summary>
		/// <param name="@name">The name of the event.</param>
		/// <param name="@code">The unique code of the event.</param>
		/// <param name="@id">The id of the event to save (leave empty to create a new one).</param>
		/// <param name="@codegroup">Optional code to group events.</param>
		/// <param name="@term">The term of the event.</param>
		/// <param name="@department">The department of the event.</param>
		/// <param name="@details">The details of the event.</param>
		/// <param name="@type">Event type.</param>
		/// <param name="@recurringschedule">The recurring schedule of the event, a JSON-formatted array. Each item must contain an action (set/remove) and the schedule properties, as returned by event.get.</param>
		/// <param name="@onetimeschedule">The one-time schedule of the event, a JSON-formatted array. Each item must contain an action (set/remove) and the schedule properties, as returned by event.get.</param>


		public static ActionResult Save(string @name, string @code, Guid @id, string @codegroup, string @term, string @department, string @details, string @type, string @recurringschedule, string @onetimeschedule
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "event.save", new {@name, @code, @id, @codegroup, @term, @department, @details, @type, @recurringschedule, @onetimeschedule
});
		}

		

	}
}


