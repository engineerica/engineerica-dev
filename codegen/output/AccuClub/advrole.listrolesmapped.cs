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
		/// Lists the roles mappings.  This action requires authentication.
		/// </summary>


		public static ActionResult Listrolesmapped(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.listrolesmapped", new {
});
		}

		
		/// <summary>
		/// Lists the roles mappings
		/// </summary>
		/// <param name="@map">List only the roles in the specified map.</param>


		public static ActionResult Listrolesmapped(string @map
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.listrolesmapped", new {@map
});
		}

		

	}
}


