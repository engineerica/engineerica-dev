using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Logouts.
	/// </summary>
	public static partial class Logout
	{
		
		/// <summary>
		/// Logout.  This action requires authentication.
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "logout", new {
});
		}

		

	}
}


