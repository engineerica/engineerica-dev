using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Terms.
	/// </summary>
	public static partial class Term
	{
		
		/// <summary>
		/// Deletes a term.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the term to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "term.delete", new {@id
});
		}

		

	}
}


