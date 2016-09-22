using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Appointments.
	/// </summary>
	public static partial class Appointment
	{
		
		/// <summary>
		/// Get the current appointments for the user that is about to sign-in via the specified sign-in station.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@user">The card of the user.</param>
		/// <param name="@location">The id of the location where the user wants to sign-in.</param>


		public static ActionResult Getcurrent(Guid @station, string @user, Guid @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "appointment.getcurrent", new {@station, @user, @location
});
		}

		

	}
}


