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
		/// View all the sessions the logged user is registered to.  This action requires authentication.
		/// </summary>


		public static ActionResult Getmysessions(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.getmysessions", new {
});
		}

		
		/// <summary>
		/// View all the sessions the logged user is registered to
		/// </summary>
		/// <param name="@date">Start date to filter the sessions.</param>


		public static ActionResult Getmysessions(DateTime @date
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionreg.getmysessions", new {@date
});
		}

		

	}
}


