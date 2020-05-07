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
		/// Gets all the comments for a rating.  This action requires authentication.
		/// </summary>
		/// <param name="@ratingid">The ID of the rating to get all comments.</param>


		public static ActionResult Getcomments(Guid @ratingid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.getcomments", new {@ratingid
});
		}

		

	}
}


