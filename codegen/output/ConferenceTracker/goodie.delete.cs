using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Goodies.
	/// </summary>
	public static partial class Goodie
	{
		
		/// <summary>
		/// Deletes a handout.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the handout to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "goodie.delete", new {@id
});
		}

		

	}
}


