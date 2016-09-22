using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Leads.
	/// </summary>
	public static partial class Lead
	{
		
		/// <summary>
		/// Generates a random drawing of N attendees with at least a certain amount of exhibitor scans..  This action requires authentication.
		/// </summary>
		/// <param name="@minscans">The minimum number of exhibitor scans required to enter the drawing.</param>
		/// <param name="@count">The max number of attendees to return.</param>


		public static ActionResult Randomdrawing(int @minscans, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.randomdrawing", new {@minscans, @count
});
		}

		
		/// <summary>
		/// Generates a random drawing of N attendees with at least a certain amount of exhibitor scans.
		/// </summary>
		/// <param name="@minscans">The minimum number of exhibitor scans required to enter the drawing.</param>
		/// <param name="@count">The max number of attendees to return.</param>
		/// <param name="@conference">The id of the conference whose leads have to be returned.</param>
		/// <param name="@exhibitorcompany">Id of the exhibitor company to perform the drawing. For exhibitors, this options is not taken into account.</param>


		public static ActionResult Randomdrawing(int @minscans, int @count, Guid @conference, Guid @exhibitorcompany
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "lead.randomdrawing", new {@minscans, @count, @conference, @exhibitorcompany
});
		}

		

	}
}


