using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshopregs.
	/// </summary>
	public static partial class Workshopreg
	{
		
		/// <summary>
		/// Gets the list of attendees registered in a workshop.  This action requires authentication.
		/// </summary>
		/// <param name="@workshopid">The id of the workshop to return the list of registered attendees.</param>


		public static ActionResult Listattendees(Guid @workshopid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshopreg.listattendees", new {@workshopid
});
		}

		

	}
}


