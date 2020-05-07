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
		/// Gets info of pre-saved and pre-approved ratings
		/// </summary>
		/// <param name="@getgroup">The ID of the group of pending ratings to get.</param>


		public static ActionResult Getpending(Guid @getgroup
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "rating.getpending", new {@getgroup
});
		}

		
		/// <summary>
		/// Gets info of pre-saved and pre-approved ratings
		/// </summary>
		/// <param name="@getgroup">The ID of the group of pending ratings to get.</param>
		/// <param name="@rateid">Rate this before returning.</param>
		/// <param name="@rateval">The value used to rate the item specified in rateid.</param>


		public static ActionResult Getpending(Guid @getgroup, Guid @rateid, int @rateval
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "rating.getpending", new {@getgroup, @rateid, @rateval
});
		}

		

	}
}


