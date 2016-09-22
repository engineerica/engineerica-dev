using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Usergroups.
	/// </summary>
	public static partial class Usergroup
	{
		
		/// <summary>
		/// Unassign tags from the members of a specified group.  This action requires authentication.
		/// </summary>
		/// <param name="@group">The id of the group to save whose members have to be untagged.</param>


		public static ActionResult Untagmembers(Guid @group
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "usergroup.untagmembers", new {@group
});
		}

		
		/// <summary>
		/// Unassign tags from the members of a specified group
		/// </summary>
		/// <param name="@group">The id of the group to save whose members have to be untagged.</param>
		/// <param name="@tags">The tags to unassign from the members of the specified group, in JSON format.</param>


		public static ActionResult Untagmembers(Guid @group, string @tags
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "usergroup.untagmembers", new {@group, @tags
});
		}

		

	}
}


