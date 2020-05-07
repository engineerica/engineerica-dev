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
		/// Gets the locations available in a sign-in station.
		/// </summary>
		/// <param name="@station">The id of the sign-in station whose locations have to be returned.</param>
		/// <param name="@user">The card of the user.</param>


		public static ActionResult Getlocations(Guid @station, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getlocations", new {@station, @user
});
		}

		

	}
}


