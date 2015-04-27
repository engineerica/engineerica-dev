using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Sends via e-mail the registration's payment information.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the registration whose payment info has to be sent.</param>


		public static ActionResult Sendpaymentinfo(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.sendpaymentinfo", new {@id
});
		}

		

	}
}


