using System;

namespace EngineericaApi.AccuClass
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.printlabels", new {
});
		}

		
		/// <summary>
		/// Prints QR Labels.
		/// </summary>
		/// <param name="@student">The id of the user whose label needs to be printed.</param>
		/// <param name="@group">The id of the group whose members labels need to be printed.</param>


		public static ActionResult Printlabels(Guid @student, Guid @group
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.printlabels", new {@student, @group
});
		}

		

	}
}


