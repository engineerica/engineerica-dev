using System;

namespace EngineericaApi.AccuCampus
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "user.changepwd", new {@oldpass, @newpass
});
		}

		

	}
}


