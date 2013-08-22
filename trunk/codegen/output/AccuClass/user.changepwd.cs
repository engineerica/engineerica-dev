using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Get user.  This action requires authentication.
		/// </summary>
		/// <param name="@oldpass">The old password of the authenticated user.</param>
		/// <param name="@newpass">The new password of the authenticated user.</param>


		public static ActionResult Changepwd(Guid @oldpass, Guid @newpass
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.changepwd", new {@oldpass, @newpass
});
		}

		

	}
}


