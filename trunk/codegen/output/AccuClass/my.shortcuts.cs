using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public partial class My : ActionSet
	{
		
		/// <summary>
		/// Returns the list of tasks or links that the user might be interested of..  This action requires authentication.
		/// </summary>


		public ActionResult Shortcuts(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "my.shortcuts", new {
});
		}

		

	}
}


