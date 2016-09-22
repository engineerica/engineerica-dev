using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Cancels or restores a specific session.  This action requires authentication.
		/// </summary>
		/// <param name="@sessionid">The id of the session to cancel or restore.</param>
		/// <param name="@cancel">True to cancel, false to restore a canceled one.</param>


		public static ActionResult Cancel(Guid @sessionid, bool @cancel
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "session.cancel", new {@sessionid, @cancel
});
		}

		

	}
}


