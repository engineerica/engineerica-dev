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
		/// Deletes a role mapping.  This action requires authentication.
		/// </summary>
		/// <param name="@map">The map name to save the role.</param>
		/// <param name="@roleid">The id of the role.</param>


		public static ActionResult Deletemapping(string @map, Guid @roleid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.deletemapping", new {@map, @roleid
});
		}

		

	}
}


