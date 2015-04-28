using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usertasks.
	/// </summary>
	public static partial class Usertask
	{
		
		/// <summary>
		/// Lists task plans.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listplan(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "usertask.listplan", new {@from, @count
});
		}

		

	}
}


