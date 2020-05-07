using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Save new registrations to a conference.  This action requires authentication.
		/// </summary>
		/// <param name="@registrations">A JSON array containing the submitted registrations.</param>


		public static ActionResult Create(string @registrations
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.create", new {@registrations
});
		}

		
		/// <summary>
		/// Save new registrations to a conference
		/// </summary>
		/// <param name="@registrations">A JSON array containing the submitted registrations.</param>
		/// <param name="@domain">The account's domain.</param>


		public static ActionResult Create(string @registrations, string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.create", new {@registrations, @domain
});
		}

		

	}
}


