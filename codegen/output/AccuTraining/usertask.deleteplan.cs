using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usertasks.
	/// </summary>
	public static partial class Usertask
	{
		
		/// <summary>
		/// Deletes a task plan.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the task plan to delete.</param>


		public static ActionResult Deleteplan(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usertask.deleteplan", new {@id
});
		}

		

	}
}


