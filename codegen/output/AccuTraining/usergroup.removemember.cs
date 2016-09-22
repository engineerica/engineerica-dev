using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usergroups.
	/// </summary>
	public static partial class Usergroup
	{
		
		/// <summary>
		/// Removes a user from a group.  This action requires authentication.
		/// </summary>
		/// <param name="@userid">The id of the user to remove.</param>
		/// <param name="@groupid">The id of the group.</param>


		public static ActionResult Removemember(Guid @userid, Guid @groupid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usergroup.removemember", new {@userid, @groupid
});
		}

		

	}
}


