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
		/// Gets the session attendance information for a specific attendee.  This action requires authentication.
		/// </summary>
		/// <param name="@attendee">The id of the attendee to get statistic for.</param>
		/// <param name="@eventid">The id of the event whose attendee statistics have to be returned.</param>


		public static ActionResult Getuser(Guid @attendee, Guid @eventid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.getuser", new {@attendee, @eventid
});
		}

		

	}
}


