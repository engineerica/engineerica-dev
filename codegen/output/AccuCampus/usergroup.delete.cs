using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Usergroups.
	/// </summary>
	public static partial class Usergroup
	{
		
		/// <summary>
		/// Deletes a group.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the group to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "usergroup.delete", new {@id
});
		}

		

	}
}


