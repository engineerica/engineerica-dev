using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Exports check-in data (including delivered goodies) saved in the system..  This action requires authentication.
		/// </summary>


		public static ActionResult Checkinswithdeliveredgoodies(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.checkinswithdeliveredgoodies", new {
});
		}

		
		/// <summary>
		/// Exports check-in data (including delivered goodies) saved in the system.
		/// </summary>
		/// <param name="@exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>


		public static ActionResult Checkinswithdeliveredgoodies(string @exportformat
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "export.checkinswithdeliveredgoodies", new {@exportformat
});
		}

		

	}
}


