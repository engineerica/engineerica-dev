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
		/// <param name="@id">The id of the registration to enable.</param>


		public static ActionResult Enable(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.enable", new {@id
});
		}

		

	}
}


