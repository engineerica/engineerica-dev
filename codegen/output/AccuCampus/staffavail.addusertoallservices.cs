using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Staffavails.
	/// </summary>
	public static partial class Staffavail
	{
		
		/// <summary>
		/// Adds a user to all services.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to add.</param>


		public static ActionResult Addusertoallservices(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.addusertoallservices", new {@userid
});
		}

		

	}
}


