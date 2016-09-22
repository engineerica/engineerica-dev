using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Send e-mail to the specified user(s) to set/change their passwords.  This action requires authentication.
		/// </summary>


		public static ActionResult Savepwdchange(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "user.savepwdchange", new {
});
		}

		
		/// <summary>
		/// Send e-mail to the specified user(s) to set/change their passwords
		/// </summary>
		/// <param name="@users">A JSON array containing the ids of the users whose passwords have to be set.</param>
		/// <param name="@role">A specific role whose users passwords have to be set.</param>


		public static ActionResult Savepwdchange(string @users, Guid @role
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "user.savepwdchange", new {@users, @role
});
		}

		

	}
}


