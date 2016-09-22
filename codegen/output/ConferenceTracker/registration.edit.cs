using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// Edit an already created registration.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the registration to edit.</param>
		/// <param name="@responses">The submitted form's responses (in JSON)</param>


		public static ActionResult Edit(Guid @id, string @responses
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.edit", new {@id, @responses
});
		}

		
		/// <summary>
		/// Edit an already created registration
		/// </summary>
		/// <param name="@id">The id of the registration to edit.</param>
		/// <param name="@responses">The submitted form's responses (in JSON)</param>
		/// <param name="@workshops">A comma-separated string containing the ids of the workshops the user is registering to.</param>
		/// <param name="@exhibitoradmintracksleads">Specifies if the exhibitor administrator should have a conference leads license.</param>
		/// <param name="@exhibitorreps">A JSON array containing the exhibitor representatives information.</param>


		public static ActionResult Edit(Guid @id, string @responses, string @workshops, bool @exhibitoradmintracksleads, string @exhibitorreps
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.edit", new {@id, @responses, @workshops, @exhibitoradmintracksleads, @exhibitorreps
});
		}

		

	}
}


