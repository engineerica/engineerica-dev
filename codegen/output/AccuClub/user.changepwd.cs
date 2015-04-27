using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Change own password.  This action requires authentication.
		/// </summary>
		/// <param name="@oldpass">The old password of the authenticated user.</param>
		/// <param name="@newpass">The new password of the authenticated user.</param>


		public static ActionResult Changepwd(Guid @oldpass, Guid @newpass
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "user.changepwd", new {@oldpass, @newpass
});
		}

		

	}
}


