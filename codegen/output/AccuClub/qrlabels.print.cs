using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Qrlabelss.
	/// </summary>
	public static partial class Qrlabels
	{
		
		/// <summary>
		/// Prints QR Labels..  This action requires authentication.
		/// </summary>


		public static ActionResult Print(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "qrlabels.print", new {
});
		}

		
		/// <summary>
		/// Prints QR Labels.
		/// </summary>
		/// <param name="@user">The id of the user whose label needs to be printed.</param>
		/// <param name="@group">The id of the group whose members' labels need to be printed.</param>


		public static ActionResult Print(Guid @user, Guid @group
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "qrlabels.print", new {@user, @group
});
		}

		

	}
}


