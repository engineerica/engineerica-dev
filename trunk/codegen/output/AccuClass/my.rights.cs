using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public partial class My : ActionSet
	{
		
		/// <summary>
		/// Returns the list of actions that the user can execute..  This action requires authentication.
		/// </summary>


		public ActionResult Rights(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "my.rights", new {
});
		}

		

	}
}


