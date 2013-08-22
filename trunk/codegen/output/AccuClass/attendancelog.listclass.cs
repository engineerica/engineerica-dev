using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance statuses for the whole class.  This action requires authentication.
		/// </summary>
		/// <param name="@classid">The id of the class whose students attendance have to be returned.</param>


		public static ActionResult Listclass(Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.listclass", new {@classid
});
		}

		

	}
}


