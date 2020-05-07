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
		/// Get a service category.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the category to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compasscategory.get", new {@id
});
		}

		

	}
}


