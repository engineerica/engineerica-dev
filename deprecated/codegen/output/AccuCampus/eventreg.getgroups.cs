using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Lists the event groups registrations of a specific user.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The user id to list events.</param>
		/// <param name="@listname">The name of the list where the user is registered.</param>


		public static ActionResult Getgroups(Guid @userid, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getgroups", new {@userid, @listname
});
		}

		

	}
}


