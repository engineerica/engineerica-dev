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
		/// Finds staff available by service, date, event, etc.  This action requires authentication.
		/// </summary>
		/// <param name="@serviceids">CSV list of the service ids to filter by.</param>
		/// <param name="@starttime">The start time of the range to look for slots.</param>
		/// <param name="@endtime">The end time of the range to look for slots.</param>


		public static ActionResult Findstaff(string @serviceids, DateTime @starttime, DateTime @endtime
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.findstaff", new {@serviceids, @starttime, @endtime
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


		public static ActionResult Findstaff(string @serviceids, DateTime @starttime, DateTime @endtime, Guid @eventid, Guid @locationid, string @staffroleids
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.findstaff", new {@serviceids, @starttime, @endtime, @eventid, @locationid, @staffroleids
});
		}

		

	}
}


