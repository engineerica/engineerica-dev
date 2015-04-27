using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Lists the roles templates..  This action requires authentication.
		/// </summary>


		public static ActionResult Listtemplates(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "advrole.listtemplates", new {
});
		}

		

	}
}


