using System;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usergroup.save", new {@name
});
		}

		
		/// <summary>
		/// Saves a group
		/// </summary>
		/// <param name="@name">The name of the group.</param>
		/// <param name="@id">The id of the group to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the group.</param>


		public static ActionResult Save(string @name, Guid @id, string @description
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usergroup.save", new {@name, @id, @description
});
		}

		

	}
}


