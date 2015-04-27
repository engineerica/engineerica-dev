using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports all workshops' registrations in the system..  This action requires authentication.
		/// </summary>


		public static ActionResult Workshopregistrations(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.workshopregistrations", new {
});
		}

		
		/// <summary>
		/// Exports all workshops' registrations in the system.
		/// </summary>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public static ActionResult Workshopregistrations(string @exportformat
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.workshopregistrations", new {@exportformat
});
		}

		

	}
}


