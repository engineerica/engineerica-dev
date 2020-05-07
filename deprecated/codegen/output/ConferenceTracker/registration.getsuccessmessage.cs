using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Get registration success message
		/// </summary>
		/// <param name="@domain">The domain of the account whose success message is to be retrieved.</param>


		public static ActionResult Getsuccessmessage(string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, false, "registration.getsuccessmessage", new {@domain
});
		}

		

	}
}


