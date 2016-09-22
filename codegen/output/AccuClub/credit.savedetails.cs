using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Credits.
	/// </summary>
	public static partial class Credit
	{
		
		/// <summary>
		/// Saves credit details.  This action requires authentication.
		/// </summary>
		/// <param name="@credit">The Id of the credit.</param>


		public static ActionResult Savedetails(Guid @credit
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "credit.savedetails", new {@credit
});
		}

		
		/// <summary>
		/// Saves credit details
		/// </summary>
		/// <param name="@credit">The Id of the credit.</param>
		/// <param name="@id">The id of the credit detail to save (leave empty to create a new one).</param>
		/// <param name="@amount">The amount of credits, if updating, it will not be used.</param>
		/// <param name="@notes">Admin notes</param>


		public static ActionResult Savedetails(Guid @credit, Guid @id, decimal @amount, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "credit.savedetails", new {@credit, @id, @amount, @notes
});
		}

		

	}
}


