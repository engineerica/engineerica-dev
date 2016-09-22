using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Saves a role mapping.  This action requires authentication.
		/// </summary>
		/// <param name="@map">The map name to save the role.</param>
		/// <param name="@roleid">The id of the role.</param>


		public static ActionResult Savemapping(string @map, Guid @roleid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "advrole.savemapping", new {@map, @roleid
});
		}

		

	}
}


