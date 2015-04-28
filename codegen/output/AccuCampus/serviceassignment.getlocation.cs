using System;

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

		

	}
}


