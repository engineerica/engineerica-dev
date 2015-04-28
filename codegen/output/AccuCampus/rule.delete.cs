using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Rules.
	/// </summary>
	public static partial class Rule
	{
		
		/// <summary>
		/// Deletes a rule.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the rule to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rule.delete", new {@id
});
		}

		

	}
}


