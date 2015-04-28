using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actionpacks.
	/// </summary>
	public static partial class Actionpack
	{
		
		/// <summary>
		/// Assign an action pack to a user.  This action requires authentication.
		/// </summary>
		/// <param name="@pack">The id of the action pack to assign.</param>
		/// <param name="@assignee">The assignee of the pack.</param>
		/// <param name="@itemsdata">A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, NotifyAssigne).</param>


		public static ActionResult Assign(Guid @pack, string @assignee, bool @itemsdata
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionpack.assign", new {@pack, @assignee, @itemsdata
});
		}

		
		/// <summary>
		/// Assign an action pack to a user
		/// </summary>
		/// <param name="@pack">The id of the action pack to assign.</param>
		/// <param name="@assignee">The assignee of the pack.</param>
		/// <param name="@itemsdata">A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, NotifyAssigne).</param>
		/// <param name="@notes">The assignment's notes.</param>


		public static ActionResult Assign(Guid @pack, string @assignee, bool @itemsdata, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionpack.assign", new {@pack, @assignee, @itemsdata, @notes
});
		}

		

	}
}


