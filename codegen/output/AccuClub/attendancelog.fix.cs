using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Fixes attendance logs.  This action requires authentication.
		/// </summary>
		/// <param name="@status">Apply only to logs with the given status. Valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, valid</param>


		public static ActionResult Fix(string @status
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "attendancelog.fix", new {@status
});
		}

		
		/// <summary>
		/// Fixes attendance logs
		/// </summary>
		/// <param name="@status">Apply only to logs with the given status. Valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, valid</param>
		/// <param name="@removebefore">True to remove the swipes before the session started.</param>
		/// <param name="@removeafter">True to remove the swipes after the session ended.</param>
		/// <param name="@createstart">Create a swipe at the beginning of the session for each log.</param>
		/// <param name="@createend">Create a swipe at the end of the session for each log.</param>
		/// <param name="@changestartswipes">Change all swipes close to the start to be a sign-ins (in a 10' frame)</param>
		/// <param name="@changeendswipes">Change all swipes close to the end to be a sign-outs (in a 10' frame)</param>
		/// <param name="@event">Apply to all att logs of this event.</param>


		public static ActionResult Fix(string @status, bool @removebefore, bool @removeafter, bool @createstart, bool @createend, bool @changestartswipes, bool @changeendswipes, Guid @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "attendancelog.fix", new {@status, @removebefore, @removeafter, @createstart, @createend, @changestartswipes, @changeendswipes, @event
});
		}

		

	}
}


