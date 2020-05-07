using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// List the id of the students expected during a period of time.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@classroomid">The classroom to get the users.</param>


		public static ActionResult Listexpected(int @from, int @count, Guid @classroomid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.listexpected", new {@from, @count, @classroomid
});
		}

		
		/// <summary>
		/// List the id of the students expected during a period of time
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@classroomid">The classroom to get the users.</param>
		/// <param name="@nextdays">The period (in days) to get the expected users, default 7.</param>


		public static ActionResult Listexpected(int @from, int @count, Guid @classroomid, int @nextdays
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.listexpected", new {@from, @count, @classroomid, @nextdays
});
		}

		

	}
}


