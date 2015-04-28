using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Enable registration.  This action requires authentication.
		/// </summary>


		public static ActionResult Enable(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.enable", new {
});
		}

		
		/// <summary>
		/// Enable registration
		/// </summary>
		/// <param name="@id">The id of the registration to enable.</param>
		/// <param name="@allwithstatus">Enables all registration with the specified status</param>


		public static ActionResult Enable(Guid @id, string @allwithstatus
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.enable", new {@id, @allwithstatus
});
		}

		

	}
}


