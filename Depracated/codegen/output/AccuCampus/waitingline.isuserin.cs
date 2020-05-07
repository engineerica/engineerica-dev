using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Waitinglines.
	/// </summary>
	public static partial class Waitingline
	{
		
		/// <summary>
		/// Check whether a user is in a waiting line, signed-in or is not in the area
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@user">The card number of the user.</param>


		public static ActionResult Isuserin(Guid @station, DateTime @time, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "waitingline.isuserin", new {@station, @time, @user
});
		}

		

	}
}


