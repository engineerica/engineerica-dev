using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Save the form that the exhibitors must complete for every lead.  This action requires authentication.
		/// </summary>
		/// <param name="@layout">The form's layout (in JSON).</param>


		public static ActionResult Saveform(string @layout
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.saveform", new {@layout
});
		}

		
		/// <summary>
		/// Save the form that the exhibitors must complete for every lead
		/// </summary>
		/// <param name="@layout">The form's layout (in JSON).</param>
		/// <param name="@id">The company's id who's the owner of the leads form to be saved.</param>


		public static ActionResult Saveform(string @layout, Guid? @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.saveform", new {@layout, @id
});
		}

		

	}
}


