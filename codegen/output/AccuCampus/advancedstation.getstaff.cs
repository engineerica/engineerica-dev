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
		/// Gets the staff/tutors available for a specific location, course and service.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@locationid">The id of the location the student picked.</param>
		/// <param name="@user">The card of the user.</param>


		public static ActionResult Getstaff(Guid @station, Guid @locationid, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getstaff", new {@station, @locationid, @user
});
		}

		
		/// <summary>
		/// Gets the staff/tutors available for a specific location, course and service.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@locationid">The id of the location the student picked.</param>
		/// <param name="@user">The card of the user.</param>
		/// <param name="@services">The list of services selected by the user, in JSON format.</param>
		/// <param name="@eventid">The ID of the event selected.</param>


		public static ActionResult Getstaff(Guid @station, Guid @locationid, string @user, string @services, Guid @eventid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getstaff", new {@station, @locationid, @user, @services, @eventid
});
		}

		

	}
}


