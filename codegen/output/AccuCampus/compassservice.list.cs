using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Compassservices.
	/// </summary>
	public static partial class Compassservice
	{
		
		/// <summary>
		/// View all the services added to the compass.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compassservice.list", new {
});
		}

		
		/// <summary>
		/// View all the services added to the compass
		/// </summary>
		/// <param name="@category">The id of the category to filter the services.</param>


		public static ActionResult List(Guid @category
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "compassservice.list", new {@category
});
		}

		

	}
}


