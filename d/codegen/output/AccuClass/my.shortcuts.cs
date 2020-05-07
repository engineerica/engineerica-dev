using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Returns the list of tasks or links that the user might be interested of..  This action requires authentication.
		/// </summary>


		public static ActionResult Shortcuts(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "my.shortcuts", new {
});
		}

		

	}
}


