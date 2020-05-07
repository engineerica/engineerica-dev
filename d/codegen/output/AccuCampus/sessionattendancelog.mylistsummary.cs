using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionattendancelogs.
	/// </summary>
	public static partial class Sessionattendancelog
	{
		
		/// <summary>
		/// View the attendance summary of the logged user.  This action requires authentication.
		/// </summary>


		public static ActionResult Mylistsummary(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.mylistsummary", new {
});
		}

		
		/// <summary>
		/// View the attendance summary of the logged user
		/// </summary>
		/// <param name="@eventid">The id of the event whose attendance has to be returned.</param>
		/// <param name="@start">The start date to filter (beginning of time by default).</param>
		/// <param name="@end">The end date to filter (today by default).</param>


		public static ActionResult Mylistsummary(Guid @eventid, string @start, string @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.mylistsummary", new {@eventid, @start, @end
});
		}

		

	}
}


