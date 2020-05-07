using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usertasks.
	/// </summary>
	public static partial class Usertask
	{
		
		/// <summary>
		/// Gets a task plan by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the task plan to get.</param>


		public static ActionResult Getplan(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usertask.getplan", new {@id
});
		}

		

	}
}


