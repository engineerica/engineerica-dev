using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Exhibitorreps.
	/// </summary>
	public static partial class Exhibitorrep
	{
		
		/// <summary>
		/// List exhibitor representatives.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "exhibitorrep.list", new {@from, @count
});
		}

		
		/// <summary>
		/// List exhibitor representatives
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@companyid">Filter users by company</param>


		public static ActionResult List(int @from, int @count, Guid @companyid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "exhibitorrep.list", new {@from, @count, @companyid
});
		}

		

	}
}


