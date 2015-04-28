using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advancedstations.
	/// </summary>
	public static partial class Advancedstation
	{
		
		/// <summary>
		/// Gets the services available for a specific location.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>


		public static ActionResult Getservices(Guid @station
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getservices", new {@station
});
		}

		
		/// <summary>
		/// Gets the services available for a specific location.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@location">The id of the location the student picked.</param>


		public static ActionResult Getservices(Guid @station, Guid @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getservices", new {@station, @location
});
		}

		

	}
}


