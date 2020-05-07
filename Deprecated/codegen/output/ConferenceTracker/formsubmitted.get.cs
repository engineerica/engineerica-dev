using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Formsubmitteds.
	/// </summary>
	public static partial class Formsubmitted
	{
		
		/// <summary>
		/// Get submitted form.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the form.</param>


		public static ActionResult Get(string @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "formsubmitted.get", new {@id
});
		}

		

	}
}


