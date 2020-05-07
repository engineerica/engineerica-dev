using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Usergroups.
	/// </summary>
	public static partial class Usergroup
	{
		
		/// <summary>
		/// Saves a group.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the group.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "usergroup.save", new {@name
});
		}

		
		/// <summary>
		/// Saves a group
		/// </summary>
		/// <param name="@name">The name of the group.</param>
		/// <param name="@id">The id of the group to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the group.</param>
		/// <param name="@isprivate">Whether this group can be seen by others other than the creator.</param>
		/// <param name="@viewroles">The roles that can view the group, in JSON format.</param>
		/// <param name="@editroles">The roles that can edit the group, in JSON format.</param>
		/// <param name="@scopes">The scopes that have access to this group, in JSON format.</param>


		public static ActionResult Save(string @name, Guid @id, string @description, bool @isprivate, string @viewroles, string @editroles, string @scopes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "usergroup.save", new {@name, @id, @description, @isprivate, @viewroles, @editroles, @scopes
});
		}

		

	}
}


