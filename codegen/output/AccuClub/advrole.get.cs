using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Get a role.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the location to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.get", new {@id
});
		}

		

	}
}


