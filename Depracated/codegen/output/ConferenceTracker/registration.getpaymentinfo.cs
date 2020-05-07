using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Gets the registration's payment information.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the registration whose payment info has to be retrieved.</param>


		public static ActionResult Getpaymentinfo(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.getpaymentinfo", new {@id
});
		}

		
		/// <summary>
		/// Gets the registration's payment information
		/// </summary>
		/// <param name="@id">The id of the registration whose payment info has to be retrieved.</param>
		/// <param name="@domain">The account's domain.</param>


		public static ActionResult Getpaymentinfo(string @id, string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.getpaymentinfo", new {@id, @domain
});
		}

		

	}
}


