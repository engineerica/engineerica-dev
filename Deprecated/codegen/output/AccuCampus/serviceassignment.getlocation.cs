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
		/// Gets all the services service enabled for a specific location.  This action requires authentication.
		/// </summary>
		/// <param name="@locationid">The id of the location to get.</param>


		public static ActionResult Getlocation(Guid @locationid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "serviceassignment.getlocation", new {@locationid
});
		}

		
		/// <summary>
		/// Gets all the services service enabled for a specific location
		/// </summary>
		/// <param name="@locationid">The id of the location to get.</param>
		/// <param name="@includegloballyavailable">Specifies whether the services available globally must be returned or not.</param>
		/// <param name="@namefilter">Filters the name of the services to return.</param>
		/// <param name="@count">The max number of services to return.</param>


		public static ActionResult Getlocation(Guid @locationid, bool @includegloballyavailable, bool @namefilter, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "serviceassignment.getlocation", new {@locationid, @includegloballyavailable, @namefilter, @count
});
		}

		

	}
}


