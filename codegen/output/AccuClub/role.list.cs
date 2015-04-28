using System;

namespace EngineericaApi.AccuClub
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "role.list", new {
});
		}

		

	}
}


