using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public static partial class Class
	{
		
		/// <summary>
		/// List classes.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.list", new {@from, @count
});
		}

		
		/// <summary>
		/// List classes
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@semester">The id of the semester which classes will be retrieved.</param>


		public static ActionResult List(int @from, int @count, Guid @semester
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.list", new {@from, @count, @semester
});
		}

		

	}
}


