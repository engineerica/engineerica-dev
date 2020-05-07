using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports exhibitor reps saved in the system..  This action requires authentication.
		/// </summary>


		public static ActionResult Exhibitorreps(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.exhibitorreps", new {
});
		}

		
		/// <summary>
		/// Exports exhibitor reps saved in the system.
		/// </summary>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public static ActionResult Exhibitorreps(string @exportformat
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.exhibitorreps", new {@exportformat
});
		}

		

	}
}


