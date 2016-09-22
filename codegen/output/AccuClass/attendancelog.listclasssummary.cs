using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance logs summary for the whole class.  This action requires authentication.
		/// </summary>
		/// <param name="@classid">The id of the class whose students attendance have to be returned.</param>


		public static ActionResult Listclasssummary(Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.listclasssummary", new {@classid
});
		}

		

	}
}


