using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Logins.
	/// </summary>
	public static partial class Login
	{
		
		/// <summary>
		/// Login
		/// </summary>
		/// <param name="@domain">The account domain to login.</param>
		/// <param name="@username">The username (email) of the user to login as.</param>
		/// <param name="@password">The password of the user to login as.</param>
		/// <param name="@method">The authentication method. Valid values are 'token' and 'cookie'.</param>


		public static ActionResult Execute(string @domain, string @username, string @password, string @method
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "login", new {@domain, @username, @password, @method
});
		}

		

	}
}


