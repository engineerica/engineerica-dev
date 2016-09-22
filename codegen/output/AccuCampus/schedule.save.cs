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
		/// Saves a specific schedule block.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user which schedule belongs to.</param>
		/// <param name="@start">Start date and time.</param>
		/// <param name="@end">End date and time.</param>
		/// <param name="@isavailable">Whether the user will be available.</param>


		public static ActionResult Save(Guid @userid, DateTime @start, DateTime @end, bool @isavailable
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.save", new {@userid, @start, @end, @isavailable
});
		}

		
		/// <summary>
		/// Saves a specific schedule block
		/// </summary>
		/// <param name="@userid">The id of the user which schedule belongs to.</param>
		/// <param name="@start">Start date and time.</param>
		/// <param name="@end">End date and time.</param>
		/// <param name="@isavailable">Whether the user will be available.</param>
		/// <param name="@scheduleid">The id of the schedule.</param>
		/// <param name="@dayofweek">The day of the week, for regular schedules.</param>
		/// <param name="@locationid">The id of the location where the user will be.</param>
		/// <param name="@availablefor">Specifies what the user is available for.</param>
		/// <param name="@maxattendees">The max number of attendees, if available.</param>


		public static ActionResult Save(Guid @userid, DateTime @start, DateTime @end, bool @isavailable, Guid @scheduleid, int @dayofweek, Guid @locationid, string @availablefor, int @maxattendees
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "schedule.save", new {@userid, @start, @end, @isavailable, @scheduleid, @dayofweek, @locationid, @availablefor, @maxattendees
});
		}

		

	}
}


