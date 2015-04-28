using System;

namespace EngineericaApi.AccuClub
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


		public static ActionResult Save(string @name, string @description, string @policies
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.save", new {@name, @description, @policies
});
		}

		
		/// <summary>
		/// Saves a role
		/// </summary>
		/// <param name="@name">The name of the role.</param>
		/// <param name="@description">The description of the role, for admin use.</param>
		/// <param name="@policies">The policies for the role.</param>
		/// <param name="@id">The id of the role to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, string @description, string @policies, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.save", new {@name, @description, @policies, @id
});
		}

		

	}
}


