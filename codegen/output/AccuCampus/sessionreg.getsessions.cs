using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// Lists the registrations of a specific user.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The user id to list sessions.</param>


		public static ActionResult Getsessions(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.getsessions", new {@userid
});
		}

		

	}
}


