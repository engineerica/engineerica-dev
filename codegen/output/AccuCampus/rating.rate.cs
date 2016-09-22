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
		/// Rates one entity.  This action requires authentication.
		/// </summary>
		/// <param name="@type">The entity type to rate.</param>
		/// <param name="@entityid">Id of the entity to rate.</param>
		/// <param name="@annonymous">Whether to post as annonymous.</param>


		public static ActionResult Rate(string @type, string @entityid, bool @annonymous
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.rate", new {@type, @entityid, @annonymous
});
		}

		
		/// <summary>
		/// Rates one entity
		/// </summary>
		/// <param name="@type">The entity type to rate.</param>
		/// <param name="@entityid">Id of the entity to rate.</param>
		/// <param name="@annonymous">Whether to post as annonymous.</param>
		/// <param name="@value">Value from 0 to 100 with the rating.</param>
		/// <param name="@comment">Comment associated with this review. Comment can be updated later on another request too.</param>
		/// <param name="@updatecomment">Whether to update the comments. Defaults to true.</param>


		public static ActionResult Rate(string @type, string @entityid, bool @annonymous, int @value, string @comment, bool @updatecomment
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.rate", new {@type, @entityid, @annonymous, @value, @comment, @updatecomment
});
		}

		

	}
}


