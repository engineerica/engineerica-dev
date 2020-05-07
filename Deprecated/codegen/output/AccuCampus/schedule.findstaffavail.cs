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
		/// Finds staff available by service, date, event, etc.  This action requires authentication.
		/// </summary>
		/// <param name="@serviceids">CSV list of the service ids to filter by.</param>
		/// <param name="@starttime">The start time of the range to look for slots.</param>
		/// <param name="@endtime">The end time of the range to look for slots.</param>


		public static ActionResult Findstaffavail(string @serviceids, DateTime @starttime, DateTime @endtime
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.findstaffavail", new {@serviceids, @starttime, @endtime
});
		}

		
		/// <summary>
		/// Finds staff available by service, date, event, etc
		/// </summary>
		/// <param name="@serviceids">CSV list of the service ids to filter by.</param>
		/// <param name="@starttime">The start time of the range to look for slots.</param>
		/// <param name="@endtime">The end time of the range to look for slots.</param>
		/// <param name="@eventid">The id of the event to filter by.</param>
		/// <param name="@locationid">The id of the service to filter by.</param>
		/// <param name="@staffroleids">CSV list of the staff member role ids to filter by.</param>
		/// <param name="@availablefor">Filter slots by a specific availability type.</param>


		public static ActionResult Findstaffavail(string @serviceids, DateTime @starttime, DateTime @endtime, Guid @eventid, Guid @locationid, string @staffroleids, string @availablefor
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.findstaffavail", new {@serviceids, @starttime, @endtime, @eventid, @locationid, @staffroleids, @availablefor
});
		}

		

	}
}


