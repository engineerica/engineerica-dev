using System;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "my.rights", new {
});
		}

		

	}
}


