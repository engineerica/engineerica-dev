using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Searchs.
	/// </summary>
	public static partial class Search
	{
		
		/// <summary>
		/// Get the information of the entities that can be searched.  This action requires authentication.
		/// </summary>


		public static ActionResult Getentities(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "search.getentities", new {
});
		}

		

	}
}


