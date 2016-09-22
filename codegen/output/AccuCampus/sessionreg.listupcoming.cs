using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// View all the upcoming event sessions.  This action requires authentication.
		/// </summary>
		/// <param name="@date">Only sessions in the week of the specified date will be returned.</param>


		public static ActionResult Listupcoming(DateTime @date
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.listupcoming", new {@date
});
		}

		

	}
}


