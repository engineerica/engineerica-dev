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
		/// Enables a service in a specific location.  This action requires authentication.
		/// </summary>
		/// <param name="@serviceid">The id of the service to add.</param>
		/// <param name="@locationid">The id of the location.</param>


		public static ActionResult Addservice(Guid @serviceid, Guid @locationid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "serviceassignment.addservice", new {@serviceid, @locationid
});
		}

		

	}
}


