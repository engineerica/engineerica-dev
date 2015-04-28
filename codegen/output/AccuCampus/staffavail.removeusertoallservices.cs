using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Staffavails.
	/// </summary>
	public static partial class Staffavail
	{
		
		/// <summary>
		/// Removes a user from the registration to all services.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to remove.</param>


		public static ActionResult Removeusertoallservices(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.removeusertoallservices", new {@userid
});
		}

		

	}
}


