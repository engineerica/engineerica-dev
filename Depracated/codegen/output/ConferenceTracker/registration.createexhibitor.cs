using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Save a new exhibitor registration to a conference.  This action requires authentication.
		/// </summary>
		/// <param name="@registrationresponses">A JSON array containing the submitted form's responses for each registration.</param>


		public static ActionResult Createexhibitor(string @registrationresponses
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.createexhibitor", new {@registrationresponses
});
		}

		
		/// <summary>
		/// Save a new exhibitor registration to a conference
		/// </summary>
		/// <param name="@registrationresponses">A JSON array containing the submitted form's responses for each registration.</param>
		/// <param name="@domain">The account's domain.</param>
		/// <param name="@admintracksleads">Specifies if the exhibitor administrator should have a conference leads license.</param>
		/// <param name="@exhibitorreps">A JSON array containing the exhibitor representatives information.</param>


		public static ActionResult Createexhibitor(string @registrationresponses, string @domain, bool @admintracksleads, string @exhibitorreps
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.createexhibitor", new {@registrationresponses, @domain, @admintracksleads, @exhibitorreps
});
		}

		

	}
}


