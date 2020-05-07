using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Get the form that the exhibitors must complete for every lead.  This action requires authentication.
		/// </summary>


		public static ActionResult Getform(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.getform", new {
});
		}

		
		/// <summary>
		/// Get the form that the exhibitors must complete for every lead
		/// </summary>
		/// <param name="@id">The company's id who's the owner of the leads form to be retrieved.</param>


		public static ActionResult Getform(Guid? @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.getform", new {@id
});
		}

		

	}
}


