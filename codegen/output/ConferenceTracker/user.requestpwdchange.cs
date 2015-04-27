using System;

namespace EngineericaApi.ConferenceTracker
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, false, "user.requestpwdchange", new {@domain, @email
});
		}

		

	}
}


