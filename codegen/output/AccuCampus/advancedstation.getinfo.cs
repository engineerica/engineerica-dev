using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advancedstations.
	/// </summary>
	public static partial class Advancedstation
	{
		
		/// <summary>
		/// Gets the info to display in the sign-in station by it's ID.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to get.</param>


		public static ActionResult Getinfo(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getinfo", new {@id
});
		}

		
		/// <summary>
		/// Gets the info to display in the sign-in station by it's ID.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to get.</param>
		/// <param name="@event">The id of the event (or session), to override the scheduled one.</param>


		public static ActionResult Getinfo(Guid @id, Guid @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.getinfo", new {@id, @event
});
		}

		

	}
}


