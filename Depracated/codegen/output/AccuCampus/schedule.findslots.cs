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
		/// Finds slots filtered by service, date, staff, etc.  This action requires authentication.
		/// </summary>
		/// <param name="@staffid">The id of the staff to filter by.</param>
		/// <param name="@starttime">The start time of the range to look for slots.</param>
		/// <param name="@endtime">The end time of the range to look for slots.</param>
		/// <param name="@serviceids">CSV list of the service Ids to filter by.</param>


		public static ActionResult Findslots(Guid @staffid, DateTime @starttime, DateTime @endtime, string @serviceids
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.findslots", new {@staffid, @starttime, @endtime, @serviceids
});
		}

		
		/// <summary>
		/// Finds slots filtered by service, date, staff, etc
		/// </summary>
		/// <param name="@staffid">The id of the staff to filter by.</param>
		/// <param name="@starttime">The start time of the range to look for slots.</param>
		/// <param name="@endtime">The end time of the range to look for slots.</param>
		/// <param name="@serviceids">CSV list of the service Ids to filter by.</param>
		/// <param name="@eventid">The id of the event to filter by.</param>
		/// <param name="@locationid">The id of the service to filter by.</param>
		/// <param name="@availablefor">The specific availability type to filter by.</param>


		public static ActionResult Findslots(Guid @staffid, DateTime @starttime, DateTime @endtime, string @serviceids, Guid @eventid, Guid @locationid, string @availablefor
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.findslots", new {@staffid, @starttime, @endtime, @serviceids, @eventid, @locationid, @availablefor
});
		}

		

	}
}


