using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Checks the permissions are assigned for the given roles.  This action requires authentication.
		/// </summary>
		/// <param name="@roles">CSV list of the role ids to check</param>
		/// <param name="@permissions">CSV list of the permissions to check</param>


		public static ActionResult Checkperm(string @roles, string @permissions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.checkperm", new {@roles, @permissions
});
		}

		

	}
}


