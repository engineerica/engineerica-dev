using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Goodies.
	/// </summary>
	public static partial class Goodie
	{
		
		/// <summary>
		/// Get handout.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the handout to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "goodie.get", new {@id
});
		}

		

	}
}


