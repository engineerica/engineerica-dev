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
		/// Flags one rating for moderation.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The rating to flag.</param>


		public static ActionResult Flag(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.flag", new {@id
});
		}

		
		/// <summary>
		/// Flags one rating for moderation
		/// </summary>
		/// <param name="@id">The rating to flag.</param>
		/// <param name="@comment">Comment why should this should be removed.</param>


		public static ActionResult Flag(Guid @id, string @comment
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.flag", new {@id, @comment
});
		}

		

	}
}


