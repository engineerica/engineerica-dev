using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Serviceassignments.
	/// </summary>
	public static partial class Serviceassignment
	{
		
		/// <summary>
		/// Gets the locations where the specified service is available.  This action requires authentication.
		/// </summary>
		/// <param name="@serviceid">The id of the service to get its locations.</param>


		public static ActionResult Getservice(Guid @serviceid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "serviceassignment.getservice", new {@serviceid
});
		}

		

	}
}


