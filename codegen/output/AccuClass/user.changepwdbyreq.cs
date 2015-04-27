using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Changes the user password using a change password request id
		/// </summary>
		/// <param name="@changereq">The change password request ID sent by email to the user.</param>
		/// <param name="@newpass">The new password of the user.</param>


		public static ActionResult Changepwdbyreq(string @changereq, string @newpass
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "user.changepwdbyreq", new {@changereq, @newpass
});
		}

		

	}
}


