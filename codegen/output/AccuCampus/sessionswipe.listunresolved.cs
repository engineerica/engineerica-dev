using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionswipes.
	/// </summary>
	public static partial class Sessionswipe
	{
		
		/// <summary>
		/// Gets the unresolved swipes.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listunresolved(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionswipe.listunresolved", new {@from, @count
});
		}

		

	}
}


