using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public partial class My : ActionSet
	{
		
		/// <summary>
		/// Returns the logged user's information..  This action requires authentication.
		/// </summary>


		public ActionResult Profile(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "my.profile", new {
});
		}

		

	}
}


