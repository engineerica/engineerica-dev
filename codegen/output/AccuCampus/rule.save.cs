using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Rules.
	/// </summary>
	public static partial class Rule
	{
		
		/// <summary>
		/// Saves a rule.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the rule.</param>
		/// <param name="@onevent">The event that will trigger this rule.</param>
		/// <param name="@conditionsjson">The conditions that apply to this rule.</param>
		/// <param name="@actionsjson">The actions that will be executed when this rule matches.</param>


		public static ActionResult Save(string @name, string @onevent, string @conditionsjson, string @actionsjson
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rule.save", new {@name, @onevent, @conditionsjson, @actionsjson
});
		}

		
		/// <summary>
		/// Saves a rule
		/// </summary>
		/// <param name="@name">The name of the rule.</param>
		/// <param name="@onevent">The event that will trigger this rule.</param>
		/// <param name="@conditionsjson">The conditions that apply to this rule.</param>
		/// <param name="@actionsjson">The actions that will be executed when this rule matches.</param>
		/// <param name="@id">The id of the rule to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the rule.</param>


		public static ActionResult Save(string @name, string @onevent, string @conditionsjson, string @actionsjson, Guid @id, string @description
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "rule.save", new {@name, @onevent, @conditionsjson, @actionsjson, @id, @description
});
		}

		

	}
}


