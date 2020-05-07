using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

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

		
		/// <summary>
		/// List roles
		/// </summary>
		/// <param name="@name">Filter by name of the role.</param>


		public static ActionResult List(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "role.list", new {@name
});
		}

		

	}
}


