using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Removes a user from the registration to all events.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to remove.</param>
		/// <param name="@listname">The name of the list where the user is registered.</param>


		public static ActionResult Removeusertoall(Guid @userid, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.removeusertoall", new {@userid, @listname
});
		}

		

	}
}


