using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Searchs.
	/// </summary>
	public static partial class Search
	{
		
		/// <summary>
		/// Get the information of the entities that can be searched.  This action requires authentication.
		/// </summary>


		public static ActionResult Getentities(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "search.getentities", new {
});
		}

		

	}
}


