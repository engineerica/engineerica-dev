using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public static partial class Class
	{
		
		/// <summary>
		/// Gets and repairs class sessions according to their schedule.  This action requires authentication.
		/// </summary>
		/// <param name="@classid">The id of the class to check.</param>
		/// <param name="@autorepair">True to automatically fix the invalid sessions.</param>


		public static ActionResult Checksessions(Guid @classid, bool @autorepair
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.checksessions", new {@classid, @autorepair
});
		}

		

	}
}


