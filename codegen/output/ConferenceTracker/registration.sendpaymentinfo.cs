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


		public static ActionResult Sendpaymentinfo(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.sendpaymentinfo", new {
});
		}

		
		/// <summary>
		/// Sends via e-mail the registration's payment information
		/// </summary>
		/// <param name="@id">The id of the registration whose payment info has to be sent.</param>
		/// <param name="@role">The id of the role to filter the registrations whose payment info have to be sent.</param>


		public static ActionResult Sendpaymentinfo(string @id, Guid @role
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.sendpaymentinfo", new {@id, @role
});
		}

		

	}
}


