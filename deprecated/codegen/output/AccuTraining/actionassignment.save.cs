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
		/// Save an action assignment.  This action requires authentication.
		/// </summary>
		/// <param name="@assignee">The assignee of the item.</param>
		/// <param name="@item">The action item to assign.</param>
		/// <param name="@datedue">The date when the action assignment is due.</param>
		/// <param name="@completed">Specifies if the assignment is completed or not.</param>


		public static ActionResult Save(string @assignee, string @item, DateTime @datedue, bool @completed
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionassignment.save", new {@assignee, @item, @datedue, @completed
});
		}

		
		/// <summary>
		/// Save an action assignment
		/// </summary>
		/// <param name="@assignee">The assignee of the item.</param>
		/// <param name="@item">The action item to assign.</param>
		/// <param name="@datedue">The date when the action assignment is due.</param>
		/// <param name="@completed">Specifies if the assignment is completed or not.</param>
		/// <param name="@event">The event of the assignment.</param>
		/// <param name="@followers">A JSON array containing the ids of the users that are followers of this action item</param>
		/// <param name="@notifyassignee">Specifies if the item's assignee must be notified of it.</param>
		/// <param name="@notes">The assignment's notes.</param>
		/// <param name="@autocomplete">Specifies if the assignment can be completed automatically or not.</param>


		public static ActionResult Save(string @assignee, string @item, DateTime @datedue, bool @completed, string @event, bool @followers, bool @notifyassignee, string @notes, bool @autocomplete
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionassignment.save", new {@assignee, @item, @datedue, @completed, @event, @followers, @notifyassignee, @notes, @autocomplete
});
		}

		

	}
}


