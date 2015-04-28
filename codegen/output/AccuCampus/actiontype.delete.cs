using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actiontypes.
	/// </summary>
	public static partial class Actiontype
	{
		
		/// <summary>
		/// Delete an action type.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action type to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actiontype.delete", new {@id
});
		}

		

	}
}


