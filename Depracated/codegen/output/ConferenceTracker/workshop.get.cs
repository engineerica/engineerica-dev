using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshops.
	/// </summary>
	public static partial class Workshop
	{
		
		/// <summary>
		/// Get workshop.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the workshop to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.get", new {@id
});
		}

		

	}
}


