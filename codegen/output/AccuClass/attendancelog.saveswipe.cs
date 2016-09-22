using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Saves an attendance log swipe.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the att log to update.</param>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>


		public static ActionResult Saveswipe(Guid @id, SwipeType @type
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.saveswipe", new {@id, @type
});
		}

		

	}
}


