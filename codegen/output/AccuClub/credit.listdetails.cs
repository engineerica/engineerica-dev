using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Credits.
	/// </summary>
	public static partial class Credit
	{
		
		/// <summary>
		/// Gets the credit usage details.  This action requires authentication.
		/// </summary>
		/// <param name="@credit">The id of the credit to look up for details.</param>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listdetails(Guid @credit, int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "credit.listdetails", new {@credit, @from, @count
});
		}

		

	}
}


