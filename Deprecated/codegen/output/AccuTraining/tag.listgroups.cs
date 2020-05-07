using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "tag.listgroups", new {
});
		}

		

	}
}


