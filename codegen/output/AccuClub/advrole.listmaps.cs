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
		/// Lists the maps a roles is mapped to.  This action requires authentication.
		/// </summary>
		/// <param name="@roleid">The id of the role to list the maps.</param>


		public static ActionResult Listmaps(Guid @roleid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.listmaps", new {@roleid
});
		}

		

	}
}


