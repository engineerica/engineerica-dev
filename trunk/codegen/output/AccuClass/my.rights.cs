using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Returns the list of actions that the user can execute..  This action requires authentication.
		/// </summary>


		public static ActionResult Rights(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "my.rights", new {
});
		}

		

	}
}


