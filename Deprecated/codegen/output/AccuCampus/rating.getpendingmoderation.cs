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
		/// Gets the ratings and comments that that pending for moderation.  This action requires authentication.
		/// </summary>


		public static ActionResult Getpendingmoderation(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.getpendingmoderation", new {
});
		}

		

	}
}


