using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Assignmenthistorys.
	/// </summary>
	public static partial class Assignmenthistory
	{
		
		/// <summary>
		/// Save an action assignment follow up.  This action requires authentication.
		/// </summary>
		/// <param name="@actionassignment">The action assignment's id whose follow up the user wants to save.</param>
		/// <param name="@datedue">The date when the action assignment is due.</param>
		/// <param name="@completed">Specifies if the assignment was completed or not.</param>


		public static ActionResult Save(Guid @actionassignment, DateTime @datedue, string @completed
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "assignmenthistory.save", new {@actionassignment, @datedue, @completed
});
		}

		
		/// <summary>
		/// Save an action assignment follow up
		/// </summary>
		/// <param name="@actionassignment">The action assignment's id whose follow up the user wants to save.</param>
		/// <param name="@datedue">The date when the action assignment is due.</param>
		/// <param name="@completed">Specifies if the assignment was completed or not.</param>
		/// <param name="@followers">A JSON array containing the ids of the users that are followers of this action item</param>
		/// <param name="@notifyassignee">Specifies if the item's assignee must be notified of it.</param>
		/// <param name="@notes">The assignment's follow up notes.</param>


		public static ActionResult Save(Guid @actionassignment, DateTime @datedue, string @completed, bool @followers, bool @notifyassignee, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "assignmenthistory.save", new {@actionassignment, @datedue, @completed, @followers, @notifyassignee, @notes
});
		}

		

	}
}


