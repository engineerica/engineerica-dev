using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Staffavails.
	/// </summary>
	public static partial class Staffavail
	{
		
		/// <summary>
		/// View all the availability types.  This action requires authentication.
		/// </summary>


		public static ActionResult Listtypes(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "staffavail.listtypes", new {
});
		}

		

	}
}


