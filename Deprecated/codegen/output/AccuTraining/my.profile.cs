using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Returns the logged user's information..  This action requires authentication.
		/// </summary>


		public static ActionResult Profile(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "my.profile", new {
});
		}

		
		/// <summary>
		/// Returns the logged user's information.
		/// </summary>
		/// <param name="@photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public static ActionResult Profile(int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "my.profile", new {@photosize
});
		}

		

	}
}


