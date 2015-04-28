using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advancedstations.
	/// </summary>
	public static partial class Advancedstation
	{
		
		/// <summary>
		/// Gets the courses available for a specific location and a specific student.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@location">The id of the location the student picked.</param>
		/// <param name="@user">The card of the user.</param>


		public static ActionResult Getevents(Guid @station, Guid @location, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getevents", new {@station, @location, @user
});
		}

		

	}
}


