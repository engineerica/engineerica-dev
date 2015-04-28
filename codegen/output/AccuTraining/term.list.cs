using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Terms.
	/// </summary>
	public static partial class Term
	{
		
		/// <summary>
		/// Gets all the terms.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "term.list", new {@from, @count
});
		}

		

	}
}


