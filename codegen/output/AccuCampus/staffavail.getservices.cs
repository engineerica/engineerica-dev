using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Staffavails.
	/// </summary>
	public static partial class Staffavail
	{
		
		/// <summary>
		/// Lists the service registrations of a specific user.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The user id to list services.</param>


		public static ActionResult Getservices(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.getservices", new {@userid
});
		}

		

	}
}


