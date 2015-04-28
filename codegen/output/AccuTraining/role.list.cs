using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Roles.
	/// </summary>
	public static partial class Role
	{
		
		/// <summary>
		/// List roles.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "role.list", new {
});
		}

		

	}
}


