using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Gets the unresolved swipes.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listunresolved(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.listunresolved", new {@from, @count
});
		}

		

	}
}


