using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Tags.
	/// </summary>
	public static partial class Tag
	{
		
		/// <summary>
		/// View all the entities that can be tagged.  This action requires authentication.
		/// </summary>


		public static ActionResult Listgroups(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "tag.listgroups", new {
});
		}

		

	}
}


