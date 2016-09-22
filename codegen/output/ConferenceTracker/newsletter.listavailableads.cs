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
		/// <param name="@newsletterid">Id of the newsletter to get available ads.</param>


		public static ActionResult Listavailableads(Guid @newsletterid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.listavailableads", new {@newsletterid
});
		}

		

	}
}


