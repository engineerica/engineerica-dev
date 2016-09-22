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
		/// Assign tags to the members of a specified group.  This action requires authentication.
		/// </summary>
		/// <param name="@group">The id of the group to save whose members have to be tagged.</param>


		public static ActionResult Tagmembers(Guid @group
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "usergroup.tagmembers", new {@group
});
		}

		
		/// <summary>
		/// Assign tags to the members of a specified group
		/// </summary>
		/// <param name="@group">The id of the group to save whose members have to be tagged.</param>
		/// <param name="@tags">The tags to assign to the members of the specified group, in JSON format.</param>


		public static ActionResult Tagmembers(Guid @group, string @tags
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "usergroup.tagmembers", new {@group, @tags
});
		}

		

	}
}


