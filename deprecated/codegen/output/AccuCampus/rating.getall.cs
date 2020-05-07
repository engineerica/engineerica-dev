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
		/// Gets the full ratings and comments for a specific entity.  This action requires authentication.
		/// </summary>
		/// <param name="@type">The entity type to get the rating.</param>
		/// <param name="@entityid">Id of the entity to get the ratings.</param>


		public static ActionResult Getall(string @type, string @entityid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.getall", new {@type, @entityid
});
		}

		
		/// <summary>
		/// Gets the full ratings and comments for a specific entity
		/// </summary>
		/// <param name="@type">The entity type to get the rating.</param>
		/// <param name="@entityid">Id of the entity to get the ratings.</param>
		/// <param name="@mostrecentfirst">True to show most recent first, otherwise most helpful first.</param>


		public static ActionResult Getall(string @type, string @entityid, bool @mostrecentfirst
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.getall", new {@type, @entityid, @mostrecentfirst
});
		}

		

	}
}


