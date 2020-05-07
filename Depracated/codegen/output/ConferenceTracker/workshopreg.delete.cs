using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshopregs.
	/// </summary>
	public static partial class Workshopreg
	{
		
		/// <summary>
		/// Deletes a registration from a workshop.  This action requires authentication.
		/// </summary>
		/// <param name="@workshopid">The id of the workshop to register the attendee.</param>
		/// <param name="@userid">The id of the user to register.</param>


		public static ActionResult Delete(Guid @workshopid, Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshopreg.delete", new {@workshopid, @userid
});
		}

		

	}
}


