using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Quickpanels.
	/// </summary>
	public static partial class Quickpanel
	{
		
		/// <summary>
		/// Returns the initial information required to show the quick panels.  This action requires authentication.
		/// </summary>


		public static ActionResult Init(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.init", new {
});
		}

		
		/// <summary>
		/// Returns the initial information required to show the quick panels
		/// </summary>
		/// <param name="@ignoreuserdefault">False if the results are only loaded if the QP are the default option for the user. True if load the info either way.</param>


		public static ActionResult Init(bool @ignoreuserdefault
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "quickpanel.init", new {@ignoreuserdefault
});
		}

		

	}
}


