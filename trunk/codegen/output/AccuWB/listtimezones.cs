using System;

namespace EngineericaApi.AccuWB
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, false, "listtimezones", new {
});
		}

		

	}
}


