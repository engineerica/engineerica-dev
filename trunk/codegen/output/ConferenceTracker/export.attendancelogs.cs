using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports attendance logs saved in the system..  This action requires authentication.
		/// </summary>


		public static ActionResult Attendancelogs(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.attendancelogs", new {
});
		}

		
		/// <summary>
		/// Exports attendance logs saved in the system.
		/// </summary>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public static ActionResult Attendancelogs(string @exportformat
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.attendancelogs", new {@exportformat
});
		}

		

	}
}


