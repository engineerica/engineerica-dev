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
		/// Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@attendancelog">The id of the attendance log to filter the staff members.</param>


		public static ActionResult Getlogstaff(Guid @station, Guid @attendancelog
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getlogstaff", new {@station, @attendancelog
});
		}

		

	}
}


