using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports presenters saved in the system..  This action requires authentication.
		/// </summary>


		public static ActionResult Presenters(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.presenters", new {
});
		}

		
		/// <summary>
		/// Exports presenters saved in the system.
		/// </summary>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public static ActionResult Presenters(string @exportformat
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.presenters", new {@exportformat
});
		}

		

	}
}


