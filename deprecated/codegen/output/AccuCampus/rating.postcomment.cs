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
		/// Posts a comments for in a rating.  This action requires authentication.
		/// </summary>
		/// <param name="@ratingid">The ID of the rating to post the comment.</param>
		/// <param name="@comment">Text of the comment to post.</param>
		/// <param name="@annonymous">True to post the comment annonymously.</param>


		public static ActionResult Postcomment(Guid @ratingid, string @comment, bool @annonymous
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.postcomment", new {@ratingid, @comment, @annonymous
});
		}

		

	}
}


