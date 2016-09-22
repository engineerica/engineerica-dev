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
		/// Enables or disables the schedule for a specific person.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to enable or disable the schedule.</param>
		/// <param name="@enable">True to enable schedules, false to disable.</param>


		public static ActionResult Enable(Guid @userid, bool @enable
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.enable", new {@userid, @enable
});
		}

		

	}
}


