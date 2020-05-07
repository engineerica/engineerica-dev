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
		/// Approves or rejects a comment or rating.  This action requires authentication.
		/// </summary>
		/// <param name="@type">Either 'rating' or 'comment' depending on what you want to moderate.</param>
		/// <param name="@id">Id of the rating or comment, as specified in type.</param>
		/// <param name="@approve">True to approve, false to reject.</param>


		public static ActionResult Moderate(string @type, Guid @id, bool @approve
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rating.moderate", new {@type, @id, @approve
});
		}

		

	}
}


