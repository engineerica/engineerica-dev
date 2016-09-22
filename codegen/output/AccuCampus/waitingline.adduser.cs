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
		/// Put user in a waiting line
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@user">The user's card number.</param>


		public static ActionResult Adduser(Guid @station, DateTime @time, string @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "waitingline.adduser", new {@station, @time, @user
});
		}

		
		/// <summary>
		/// Put user in a waiting line
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@time">The date and time of the swipe.</param>
		/// <param name="@user">The user's card number.</param>
		/// <param name="@locationid">The location's id where the swipe must be saved.</param>
		/// <param name="@signinrole">Specifies if the sign-in is for an attendee or a staff member</param>
		/// <param name="@services">The services ids the user has selected.</param>
		/// <param name="@eventid">The id of the event the user selected.</param>
		/// <param name="@staff">The id of the staff member the user selected.</param>
		/// <param name="@photosize">The swiping user's photo size.</param>


		public static ActionResult Adduser(Guid @station, DateTime @time, string @user, Guid? @locationid, string @signinrole, string @services, Guid? @eventid, Guid? @staff, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, false, "waitingline.adduser", new {@station, @time, @user, @locationid, @signinrole, @services, @eventid, @staff, @photosize
});
		}

		

	}
}


