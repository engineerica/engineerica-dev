using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Companys.
	/// </summary>
	public static partial class Company
	{
		
		/// <summary>
		/// Get company.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the company to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.get", new {@id
});
		}

		

	}
}


