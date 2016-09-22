using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Compasscategorys.
	/// </summary>
	public static partial class Compasscategory
	{
		
		/// <summary>
		/// Save a campus compass category.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the category.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compasscategory.save", new {@name
});
		}

		
		/// <summary>
		/// Save a campus compass category
		/// </summary>
		/// <param name="@name">The name of the category.</param>
		/// <param name="@id">The id of the category save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the category.</param>
		/// <param name="@icon">The icon name of the category.</param>


		public static ActionResult Save(string @name, Guid @id, string @description, string @icon
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compasscategory.save", new {@name, @id, @description, @icon
});
		}

		

	}
}


