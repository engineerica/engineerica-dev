using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Credits.
	/// </summary>
	public static partial class Credit
	{
		
		/// <summary>
		/// Deletes a credit.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the credit to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "credit.delete", new {@id
});
		}

		

	}
}


