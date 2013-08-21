using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// Get user.  This action requires authentication.
		/// </summary>
		/// <param name="_oldpass">The old password of the authenticated user.</param>
		/// <param name="_newpass">The new password of the authenticated user.</param>


		public ActionResult Changepwd(Guid _oldpass, Guid _newpass
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.changepwd", new {_oldpass, _newpass
});
		}

		

	}
}


