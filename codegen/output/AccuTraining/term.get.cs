using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Terms.
	/// </summary>
	public static partial class Term
	{
		
		/// <summary>
		/// Gets a term.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the term to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "term.get", new {@id
});
		}

		

	}
}


