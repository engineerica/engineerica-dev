using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Actionitems.
	/// </summary>
	public static partial class Actionitem
	{
		
		/// <summary>
		/// Save an action item.  This action requires authentication.
		/// </summary>
		/// <param name="@type">The id of the action type of the item to save.</param>
		/// <param name="@code">The code of the action item.</param>
		/// <param name="@name">The name of the action item.</param>
		/// <param name="@durationbasis">Specifies the duration basis of the action item (0 = Minutes, 1 = Hours, 2 = Days, 3 = Weeks).</param>
		/// <param name="@duration">The default duration value of the action item.</param>


		public static ActionResult Save(Guid @type, string @code, string @name, DurationBasis @durationbasis, int @duration
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionitem.save", new {@type, @code, @name, @durationbasis, @duration
});
		}

		
		/// <summary>
		/// Save an action item
		/// </summary>
		/// <param name="@type">The id of the action type of the item to save.</param>
		/// <param name="@code">The code of the action item.</param>
		/// <param name="@name">The name of the action item.</param>
		/// <param name="@durationbasis">Specifies the duration basis of the action item (0 = Minutes, 1 = Hours, 2 = Days, 3 = Weeks).</param>
		/// <param name="@duration">The default duration value of the action item.</param>
		/// <param name="@id">The id of the action item to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the action item.</param>
		/// <param name="@service">The id of the service of the item to save.</param>
		/// <param name="@eventbased">Specifies if the item is event based.</param>
		/// <param name="@followers">A JSON array containing the ids of the users that are followers of this action item</param>
		/// <param name="@notifyassignee">Specifies if the item's assignee must be notified of it.</param>


		public static ActionResult Save(Guid @type, string @code, string @name, DurationBasis @durationbasis, int @duration, Guid @id, string @description, Guid @service, bool @eventbased, bool @followers, bool @notifyassignee
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionitem.save", new {@type, @code, @name, @durationbasis, @duration, @id, @description, @service, @eventbased, @followers, @notifyassignee
});
		}

		

	}
}


