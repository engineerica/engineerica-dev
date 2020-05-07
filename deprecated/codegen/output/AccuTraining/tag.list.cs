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
		/// View all the tags.  This action requires authentication.
		/// </summary>
		/// <param name="@group">The group of the tags to return.</param>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(string @group, int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "tag.list", new {@group, @from, @count
});
		}

		

	}
}


