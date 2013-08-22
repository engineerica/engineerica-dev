using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Formsubmitteds.
	/// </summary>
	public static partial class Formsubmitted
	{
		
		/// <summary>
		/// Save a submitted form.  This action requires authentication.
		/// </summary>
		/// <param name="@form">The id of the submitted form .</param>
		/// <param name="@responses">The submitted form's responses (in JSON)</param>


		public static ActionResult Save(Guid @form, string @responses
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "formsubmitted.save", new {@form, @responses
});
		}

		
		/// <summary>
		/// Save a submitted form
		/// </summary>
		/// <param name="@form">The id of the submitted form .</param>
		/// <param name="@responses">The submitted form's responses (in JSON)</param>
		/// <param name="@domain">The account's domain.</param>


		public static ActionResult Save(Guid @form, string @responses, string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "formsubmitted.save", new {@form, @responses, @domain
});
		}

		

	}
}


