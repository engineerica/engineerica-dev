using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Creditplans.
	/// </summary>
	public static partial class Creditplan
	{
		
		/// <summary>
		/// Deletes a credit plan.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the credit plan to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "creditplan.delete", new {@id
});
		}

		

	}
}


