using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Clients.
	/// </summary>
	public static partial class Client
	{
		
		/// <summary>
		/// Gets the clients of the specified conference.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "client.list", new {@from, @count
});
		}

		

	}
}


