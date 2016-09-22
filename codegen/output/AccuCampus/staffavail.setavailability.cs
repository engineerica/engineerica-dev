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
		/// Make a staff member available for a specific availability type.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user whose specific availability has to be set.</param>


		public static ActionResult Setavailability(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.setavailability", new {@userid
});
		}

		
		/// <summary>
		/// Make a staff member available for a specific availability type
		/// </summary>
		/// <param name="@userid">The id of the user whose specific availability has to be set.</param>
		/// <param name="@availablefor">Specific availability to set.</param>


		public static ActionResult Setavailability(Guid @userid, string @availablefor
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.setavailability", new {@userid, @availablefor
});
		}

		

	}
}


