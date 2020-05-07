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
		/// Adds a user to an event group.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to add.</param>
		/// <param name="@codegroup">The code used to group events.</param>
		/// <param name="@listname">The name of the list where the user has to be registered.</param>


		public static ActionResult Addusertogroup(Guid @userid, string @codegroup, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.addusertogroup", new {@userid, @codegroup, @listname
});
		}

		

	}
}


