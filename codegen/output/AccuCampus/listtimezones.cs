using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "listtimezones", new {
});
		}

		

	}
}


