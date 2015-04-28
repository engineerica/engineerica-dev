using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advancedstations.
	/// </summary>
	public static partial class Advancedstation
	{
		
		/// <summary>
		/// Gets whether a user is signed-in or not.
		/// </summary>
		/// <param name="@station">The id of the sign-in station to get.</param>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@user">The card of the user.</param>


		public static ActionResult Issignedin(Guid @station, DateTime @time, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "advancedstation.issignedin", new {@station, @time, @user
});
		}

		

	}
}


