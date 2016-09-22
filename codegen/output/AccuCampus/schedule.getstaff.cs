using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Schedules.
	/// </summary>
	public static partial class Schedule
	{
		
		/// <summary>
		/// Gets all the schedule information for a particular person.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to get info.</param>


		public static ActionResult Getstaff(Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.getstaff", new {@userid
});
		}

		

	}
}


