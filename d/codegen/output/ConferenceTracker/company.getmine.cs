using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Companys.
	/// </summary>
	public static partial class Company
	{
		
		/// <summary>
		/// Gets information about my company.  This action requires authentication.
		/// </summary>


		public static ActionResult Getmine(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "company.getmine", new {
});
		}

		

	}
}


