using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Rules.
	/// </summary>
	public static partial class Rule
	{
		
		/// <summary>
		/// Gets a rule by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the rule to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "rule.get", new {@id
});
		}

		

	}
}


