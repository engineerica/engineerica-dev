using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actionitems.
	/// </summary>
	public static partial class Actionitem
	{
		
		/// <summary>
		/// Delete an action item.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action item to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionitem.delete", new {@id
});
		}

		

	}
}


