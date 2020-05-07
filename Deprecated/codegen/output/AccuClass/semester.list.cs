using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public static partial class Semester
	{
		
		/// <summary>
		/// List semesters.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "semester.list", new {@from, @count
});
		}

		

	}
}


