using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usertasks.
	/// </summary>
	public static partial class Usertask
	{
		
		/// <summary>
		/// Saves a task plan.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the task plan.</param>
		/// <param name="@tasks">The task definitions in JSON format.</param>
		/// <param name="@groups">A CSV list of the group ids this plan is assigned to.</param>


		public static ActionResult Saveplan(string @name, string @tasks, string @groups
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usertask.saveplan", new {@name, @tasks, @groups
});
		}

		
		/// <summary>
		/// Saves a task plan
		/// </summary>
		/// <param name="@name">The name of the task plan.</param>
		/// <param name="@tasks">The task definitions in JSON format.</param>
		/// <param name="@groups">A CSV list of the group ids this plan is assigned to.</param>
		/// <param name="@id">The id of the Task to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the task plan.</param>
		/// <param name="@validfrom">The date when the plan starts.</param>
		/// <param name="@validto">The date when the plan ends.</param>


		public static ActionResult Saveplan(string @name, string @tasks, string @groups, Guid @id, string @description, DateTime @validfrom, DateTime @validto
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usertask.saveplan", new {@name, @tasks, @groups, @id, @description, @validfrom, @validto
});
		}

		

	}
}


