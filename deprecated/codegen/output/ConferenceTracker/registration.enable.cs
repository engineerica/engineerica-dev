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
		/// <param name="@role">The id of the role to filter the registrations to enable.</param>
		/// <param name="@merge">True to merge with existent user. Defaults to false.</param>


		public static ActionResult Enable(Guid @id, string @allwithstatus, Guid @role, bool @merge
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.enable", new {@id, @allwithstatus, @role, @merge
});
		}

		

	}
}


