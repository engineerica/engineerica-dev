using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Logouts.
	/// </summary>
	public partial class Logout : ActionSet
	{
		
		/// <summary>
		/// Logout.  This action requires authentication.
		/// </summary>


		public ActionResult Execute(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "logout", new {
});
		}

		

	}
}


