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
		/// Saves a session attendance log swipe.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the att log to update.</param>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>


		public static ActionResult Saveswipe(Guid @id, AttendanceType @type
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.saveswipe", new {@id, @type
});
		}

		

	}
}


