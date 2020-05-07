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
		/// Gets a specific schedule block.  This action requires authentication.
		/// </summary>
		/// <param name="@scheduleid">The id of the schedule.</param>


		public static ActionResult Get(Guid @scheduleid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.get", new {@scheduleid
});
		}

		

	}
}


