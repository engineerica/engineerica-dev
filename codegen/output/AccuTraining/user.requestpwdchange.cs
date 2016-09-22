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
		/// Requests a password change
		/// </summary>
		/// <param name="@domain">The domain of the account where the user exists.</param>
		/// <param name="@email">The email of the user.</param>


		public static ActionResult Requestpwdchange(string @domain, string @email
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "user.requestpwdchange", new {@domain, @email
});
		}

		

	}
}


