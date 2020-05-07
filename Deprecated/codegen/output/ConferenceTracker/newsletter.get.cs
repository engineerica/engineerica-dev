using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Gets a specific newsletter by id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">Id of the newsletter to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.get", new {@id
});
		}

		

	}
}


