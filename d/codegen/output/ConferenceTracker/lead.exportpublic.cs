using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Exports the list of leads
		/// </summary>
		/// <param name="@exhibitor">The id of the exhibitor.</param>
		/// <param name="@hash">The validation hash, as sent via email to the user.</param>


		public static ActionResult Exportpublic(Guid @exhibitor, string @hash
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, false, "lead.exportpublic", new {@exhibitor, @hash
});
		}

		

	}
}


