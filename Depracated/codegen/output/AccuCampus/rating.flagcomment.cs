using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Ratings.
	/// </summary>
	public static partial class Rating
	{
		
		/// <summary>
		/// Flags one comment for moderation.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The comment to flag.</param>


		public static ActionResult Flagcomment(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.flagcomment", new {@id
});
		}

		
		/// <summary>
		/// Flags one comment for moderation
		/// </summary>
		/// <param name="@id">The comment to flag.</param>
		/// <param name="@comment">Comment why should this should be removed.</param>


		public static ActionResult Flagcomment(Guid @id, string @comment
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.flagcomment", new {@id, @comment
});
		}

		

	}
}


