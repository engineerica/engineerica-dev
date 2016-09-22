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
		/// Gets the attendance statuses for the whole event.  This action requires authentication.
		/// </summary>
		/// <param name="@eventid">The id of the event whose attendance has to be returned.</param>


		public static ActionResult Listevent(Guid @eventid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.listevent", new {@eventid
});
		}

		

	}
}


