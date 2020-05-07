using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Companys.
	/// </summary>
	public static partial class Company
	{
		
		/// <summary>
		/// Saves the limits of a specific company.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the company to update.</param>
		/// <param name="@maxleadsapps">The max number of leads apps this exhibitor can have.</param>


		public static ActionResult Savelimits(Guid @id, int @maxleadsapps
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.savelimits", new {@id, @maxleadsapps
});
		}

		
		/// <summary>
		/// Saves the limits of a specific company
		/// </summary>
		/// <param name="@id">The id of the company to update.</param>
		/// <param name="@maxleadsapps">The max number of leads apps this exhibitor can have.</param>
		/// <param name="@maxreps">The max number of reps this exhibitor can have. Do not send for unlimited.</param>


		public static ActionResult Savelimits(Guid @id, int @maxleadsapps, int @maxreps
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.savelimits", new {@id, @maxleadsapps, @maxreps
});
		}

		

	}
}


