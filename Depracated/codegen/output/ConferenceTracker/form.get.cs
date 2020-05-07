using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Forms.
	/// </summary>
	public static partial class Form
	{
		
		/// <summary>
		/// Get form.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the form.</param>


		public static ActionResult Get(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "form.get", new {@id
});
		}

		
		/// <summary>
		/// Get form
		/// </summary>
		/// <param name="@id">The id of the form.</param>
		/// <param name="@domain">The account's domain.</param>


		public static ActionResult Get(string @id, string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "form.get", new {@id, @domain
});
		}

		

	}
}


