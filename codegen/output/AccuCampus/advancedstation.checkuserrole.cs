using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advancedstations.
	/// </summary>
	public static partial class Advancedstation
	{
		
		/// <summary>
		/// Check whether the user is a staff member, an attendee or both.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@user">The card of the user.</param>
		/// <param name="@location">The id of the location the user picked.</param>


		public static ActionResult Checkuserrole(Guid @station, string @user, Guid @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.checkuserrole", new {@station, @user, @location
});
		}

		

	}
}


