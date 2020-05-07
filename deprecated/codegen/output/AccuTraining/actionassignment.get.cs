using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Actionassignments.
	/// </summary>
	public static partial class Actionassignment
	{
		
		/// <summary>
		/// Get an action assignment.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action assignment to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionassignment.get", new {@id
});
		}

		

	}
}


