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
		/// View a specified tag.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the tag to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "tag.get", new {@id
});
		}

		

	}
}


