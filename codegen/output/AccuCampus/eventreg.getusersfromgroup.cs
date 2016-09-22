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
		/// Lists the registrations for a event group.  This action requires authentication.
		/// </summary>
		/// <param name="@codegroup">The code group to list users.</param>
		/// <param name="@listname">The name of the list to get.</param>


		public static ActionResult Getusersfromgroup(Guid @codegroup, string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getusersfromgroup", new {@codegroup, @listname
});
		}

		

	}
}


