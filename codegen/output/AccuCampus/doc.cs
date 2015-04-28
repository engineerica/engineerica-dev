using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Docs.
	/// </summary>
	public static partial class Doc
	{
		
		/// <summary>
		/// Get Documentation
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "doc", new {
});
		}

		
		/// <summary>
		/// Get Documentation
		/// </summary>
		/// <param name="@excludeanonymous">If true it excludes the anonymous actions from the returned list.</param>


		public static ActionResult Execute(bool @excludeanonymous
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "doc", new {@excludeanonymous
});
		}

		

	}
}


