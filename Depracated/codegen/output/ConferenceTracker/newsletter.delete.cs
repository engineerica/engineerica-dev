using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Deletes a newsletter.  This action requires authentication.
		/// </summary>
		/// <param name="@id">Id of the newsletter to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.delete", new {@id
});
		}

		

	}
}


