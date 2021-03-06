using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Registrations.
	/// </summary>
	public static partial class Registration
	{
		
		/// <summary>
		/// List conference registrations.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference whose registrations are to be retrieved.</param>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @conference, int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.list", new {@conference, @from, @count
});
		}

		
		/// <summary>
		/// List conference registrations
		/// </summary>
		/// <param name="@conference">The id of the conference whose registrations are to be retrieved.</param>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@role">The id of the role whose registrations have to be returned.</param>
		/// <param name="@status">A comma separated list of the forms to return. Valid values are: pending, paid, paid+accepted, accepted, deleted, error.</param>


		public static ActionResult List(int @conference, int @from, int @count, Guid @role, int @status
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "registration.list", new {@conference, @from, @count, @role, @status
});
		}

		

	}
}


