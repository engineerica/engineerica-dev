using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Gets all future sessions of the current semester.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "session.list", new {@from, @count
});
		}

		

	}
}


