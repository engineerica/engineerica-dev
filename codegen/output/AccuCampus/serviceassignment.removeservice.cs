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
		/// Removes a service from a location.  This action requires authentication.
		/// </summary>
		/// <param name="@serviceid">The id of the service to remove.</param>
		/// <param name="@locationid">The id of the location to remove the service from.</param>


		public static ActionResult Removeservice(Guid @serviceid, Guid @locationid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "serviceassignment.removeservice", new {@serviceid, @locationid
});
		}

		

	}
}


