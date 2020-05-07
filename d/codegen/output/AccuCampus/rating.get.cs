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
		/// Get rating for one or more entities.  This action requires authentication.
		/// </summary>
		/// <param name="@type">The entity type to get the rating.</param>
		/// <param name="@entityids">List of ids to get the ratings.</param>


		public static ActionResult Get(string @type, string @entityids
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.get", new {@type, @entityids
});
		}

		

	}
}


