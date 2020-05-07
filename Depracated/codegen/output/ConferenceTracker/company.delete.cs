using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Companys.
	/// </summary>
	public static partial class Company
	{
		
		/// <summary>
		/// Delete a company.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the company to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.delete", new {@id
});
		}

		

	}
}


