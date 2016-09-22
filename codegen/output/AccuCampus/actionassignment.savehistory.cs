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
		/// Save an action assignment follow up.  This action requires authentication.
		/// </summary>
		/// <param name="@actionassignment">The action assignment's id whose follow up the user wants to save.</param>
		/// <param name="@datedue">The date when the action assignment is due.</param>
		/// <param name="@completed">Specifies if the assignment was completed or not.</param>


		public static ActionResult Savehistory(Guid @actionassignment, DateTime @datedue, string @completed
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionassignment.savehistory", new {@actionassignment, @datedue, @completed
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
		/// <param name="@autocomplete">Specifies if the assignment can be completed automatically or not.</param>


		public static ActionResult Savehistory(Guid @actionassignment, DateTime @datedue, string @completed, string @followers, bool @notifyassignee, string @notes, bool @autocomplete
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionassignment.savehistory", new {@actionassignment, @datedue, @completed, @followers, @notifyassignee, @notes, @autocomplete
});
		}

		

	}
}


