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
		/// Rates a pre-saved and pre-approved entity
		/// </summary>
		/// <param name="@group">The ID of the group of with pre-approved ratings.</param>
		/// <param name="@annonymous">Whether to post as annonymous.</param>


		public static ActionResult Ratepending(Guid @group, bool @annonymous
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "rating.ratepending", new {@group, @annonymous
});
		}

		
		/// <summary>
		/// Rates a pre-saved and pre-approved entity
		/// </summary>
		/// <param name="@group">The ID of the group of with pre-approved ratings.</param>
		/// <param name="@annonymous">Whether to post as annonymous.</param>
		/// <param name="@rateid">Rate this before returning.</param>
		/// <param name="@value">Value from 0 to 100 with the rating.</param>
		/// <param name="@comment">Comment associated with this review. Comment can be updated later on another request too.</param>
		/// <param name="@updatecomment">Whether to update the comments. Defaults to true.</param>


		public static ActionResult Ratepending(Guid @group, bool @annonymous, Guid @rateid, int @value, string @comment, bool @updatecomment
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "rating.ratepending", new {@group, @annonymous, @rateid, @value, @comment, @updatecomment
});
		}

		

	}
}


