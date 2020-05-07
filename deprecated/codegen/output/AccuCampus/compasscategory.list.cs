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
		/// View all the service categories.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compasscategory.list", new {
});
		}

		
		/// <summary>
		/// View all the service categories
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@onlywithservices">Specified whether only categories with services are returned or all.</param>


		public static ActionResult List(int @from, int @count, bool @onlywithservices
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compasscategory.list", new {@from, @count, @onlywithservices
});
		}

		

	}
}


