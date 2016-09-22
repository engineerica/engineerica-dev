using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Reprocess an unresolved swipe, and if possible, creates the attendance log.  This action requires authentication.
		/// </summary>


		public static ActionResult Reprocess(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.reprocess", new {
});
		}

		
		/// <summary>
		/// Reprocess an unresolved swipe, and if possible, creates the attendance log
		/// </summary>
		/// <param name="@id">The id of the unresolved swipe to reprocess.</param>


		public static ActionResult Reprocess(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.reprocess", new {@id
});
		}

		

	}
}


