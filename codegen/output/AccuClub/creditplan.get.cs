using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Creditplans.
	/// </summary>
	public static partial class Creditplan
	{
		
		/// <summary>
		/// Gets a credit plan.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the credit plan to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "creditplan.get", new {@id
});
		}

		

	}
}


