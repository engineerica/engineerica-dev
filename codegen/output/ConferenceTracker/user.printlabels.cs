using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Prints QR Labels..  This action requires authentication.
		/// </summary>


		public static ActionResult Printlabels(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "user.printlabels", new {
});
		}

		
		/// <summary>
		/// Prints QR Labels.
		/// </summary>
		/// <param name="@user">The id of the user whose label needs to be printed.</param>
		/// <param name="@workshop">The id of the workshop whose registered members labels need to be printed.</param>


		public static ActionResult Printlabels(Guid @user, Guid @workshop
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "user.printlabels", new {@user, @workshop
});
		}

		

	}
}


