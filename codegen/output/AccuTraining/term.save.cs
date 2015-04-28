using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Terms.
	/// </summary>
	public static partial class Term
	{
		
		/// <summary>
		/// Saves a term.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the term.</param>
		/// <param name="@start">The date when the term starts.</param>
		/// <param name="@end">The date when the term ends.</param>


		public static ActionResult Save(string @name, DateTime @start, DateTime @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "term.save", new {@name, @start, @end
});
		}

		
		/// <summary>
		/// Saves a term
		/// </summary>
		/// <param name="@name">The name of the term.</param>
		/// <param name="@start">The date when the term starts.</param>
		/// <param name="@end">The date when the term ends.</param>
		/// <param name="@id">The id of the term to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, DateTime @start, DateTime @end, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "term.save", new {@name, @start, @end, @id
});
		}

		

	}
}


