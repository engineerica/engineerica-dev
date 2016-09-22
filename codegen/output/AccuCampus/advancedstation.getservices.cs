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
		/// Gets the services available for a specific location.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@location">The id of the location the student picked.</param>
		/// <param name="@user">The card of the user.</param>


		public static ActionResult Getservices(Guid @station, Guid @location, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getservices", new {@station, @location, @user
});
		}

		

	}
}


