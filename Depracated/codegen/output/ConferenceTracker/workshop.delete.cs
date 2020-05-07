using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshops.
	/// </summary>
	public static partial class Workshop
	{
		
		/// <summary>
		/// Deletes a workshop.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the workshop to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.delete", new {@id
});
		}

		

	}
}


