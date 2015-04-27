using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets an attendance log's swipe change history.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the attendance log to get.</param>


		public static ActionResult Getchangehistory(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.getchangehistory", new {@id
});
		}

		

	}
}


