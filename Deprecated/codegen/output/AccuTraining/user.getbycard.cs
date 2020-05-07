using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Search user by card number.  This action requires authentication.
		/// </summary>
		/// <param name="@card">The card number of the user to get.</param>


		public static ActionResult Getbycard(string @card
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "user.getbycard", new {@card
});
		}

		
		/// <summary>
		/// Search user by card number
		/// </summary>
		/// <param name="@card">The card number of the user to get.</param>
		/// <param name="@photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public static ActionResult Getbycard(string @card, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "user.getbycard", new {@card, @photosize
});
		}

		

	}
}


