using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Exports the list of leads.  This action requires authentication.
		/// </summary>


		public static ActionResult Export(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.export", new {
});
		}

		

	}
}


