using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshopregs.
	/// </summary>
	public static partial class Workshopreg
	{
		
		/// <summary>
		/// Gets the list of workshops where an attendee is registered.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to return the list of registered workshops.</param>


		public static ActionResult Listworkshops(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshopreg.listworkshops", new {@userid
});
		}

		

	}
}


