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
		/// Votes up or down a rating.  This action requires authentication.
		/// </summary>
		/// <param name="@ratingid">The ID of the rating to vote on.</param>
		/// <param name="@vote">1 to vote up, -1 to vote down.</param>


		public static ActionResult Vote(Guid @ratingid, int @vote
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.vote", new {@ratingid, @vote
});
		}

		

	}
}


