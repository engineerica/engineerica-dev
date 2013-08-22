using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Deletes a lead.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the lead to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.delete", new {@id
});
		}

		

	}
}


