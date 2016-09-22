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
		/// Gets a session attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the attendance log to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionattendancelog.get", new {@id
});
		}

		

	}
}


