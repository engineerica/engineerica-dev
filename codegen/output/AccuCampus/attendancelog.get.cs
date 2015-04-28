using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets an attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the attendance log to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancelog.get", new {@id
});
		}

		

	}
}


