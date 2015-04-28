using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Usergroups.
	/// </summary>
	public static partial class Usergroup
	{
		
		/// <summary>
		/// Get the members of a user group.  This action requires authentication.
		/// </summary>
		/// <param name="@groupid">The id of the user group to get.</param>


		public static ActionResult Getmembers(Guid @groupid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "usergroup.getmembers", new {@groupid
});
		}

		

	}
}


