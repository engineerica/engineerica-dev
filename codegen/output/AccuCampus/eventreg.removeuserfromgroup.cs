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
		/// Removes a user from an event group.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to remove.</param>
		/// <param name="@codegroup">The code group of the events/courses.</param>
		/// <param name="@listname">The name of the list where the user is registered.</param>


		public static ActionResult Removeuserfromgroup(Guid @userid, Guid @codegroup, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.removeuserfromgroup", new {@userid, @codegroup, @listname
});
		}

		

	}
}


