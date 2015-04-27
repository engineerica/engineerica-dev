using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Staffavails.
	/// </summary>
	public static partial class Staffavail
	{
		
		/// <summary>
		/// Lists the registrations at a specific service.  This action requires authentication.
		/// </summary>
		/// <param name="@serviceid">The service id to list users.</param>


		public static ActionResult Getusersforservice(Guid @serviceid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.getusersforservice", new {@serviceid
});
		}

		

	}
}


