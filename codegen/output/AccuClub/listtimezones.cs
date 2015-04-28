using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Listtimezoness.
	/// </summary>
	public static partial class Listtimezones
	{
		
		/// <summary>
		/// Lists the available timezones
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, false, "listtimezones", new {
});
		}

		

	}
}


