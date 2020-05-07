using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Saves a role.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the role.</param>
		/// <param name="@description">The description of the role, for admin use.</param>
		/// <param name="@policies">The policies for the role.</param>
		/// <param name="@editroles">CSV list of the roles this role can edit.</param>


		public static ActionResult Save(string @name, string @description, string @policies, string @editroles
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "advrole.save", new {@name, @description, @policies, @editroles
});
		}

		
		/// <summary>
		/// Saves a role
		/// </summary>
		/// <param name="@name">The name of the role.</param>
		/// <param name="@description">The description of the role, for admin use.</param>
		/// <param name="@policies">The policies for the role.</param>
		/// <param name="@editroles">CSV list of the roles this role can edit.</param>
		/// <param name="@id">The id of the role to save (leave empty to create a new one).</param>
		/// <param name="@viewroles">CSV list of the roles this role can view.</param>


		public static ActionResult Save(string @name, string @description, string @policies, string @editroles, Guid @id, string @viewroles
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "advrole.save", new {@name, @description, @policies, @editroles, @id, @viewroles
});
		}

		

	}
}


