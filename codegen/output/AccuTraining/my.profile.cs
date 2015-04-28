using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Returns the logged user's information..  This action requires authentication.
		/// </summary>


		public static ActionResult Profile(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "my.profile", new {
});
		}

		

	}
}


