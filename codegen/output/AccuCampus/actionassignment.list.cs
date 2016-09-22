using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actionassignments.
	/// </summary>
	public static partial class Actionassignment
	{
		
		/// <summary>
		/// List action assignments.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionassignment.list", new {@from, @count
});
		}

		
		/// <summary>
		/// List action assignments
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@assignee">The assignee's id to filter the assignments.</param>
		/// <param name="@status">The status to filter the assignments.</param>


		public static ActionResult List(int @from, int @count, int @assignee, ActionAssignmentStatus @status
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionassignment.list", new {@from, @count, @assignee, @status
});
		}

		

	}
}


