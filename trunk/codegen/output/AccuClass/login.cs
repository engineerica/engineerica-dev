using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Logins.
	/// </summary>
	public partial class Login : ActionSet
	{
		
		/// <summary>
		/// Login
		/// </summary>
		/// <param name="_domain">The account domain to login.</param>
		/// <param name="_username">The username (email) of the user to login as.</param>
		/// <param name="_password">The password of the user to login as.</param>
		/// <param name="_method">The authentication method. Valid values are 'token' and 'cookie'.</param>


		public ActionResult Execute(string _domain, string _username, string _password, string _method
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "login", new {_domain, _username, _password, _method
});
		}

		

	}
}


