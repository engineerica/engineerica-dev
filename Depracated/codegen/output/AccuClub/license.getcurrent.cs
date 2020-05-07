using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Licenses.
	/// </summary>
	public static partial class License
	{
		
		/// <summary>
		/// Gets the current license information.  This action requires authentication.
		/// </summary>


		public static ActionResult Getcurrent(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "license.getcurrent", new {
});
		}

		

	}
}


