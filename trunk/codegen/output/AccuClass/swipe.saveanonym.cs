using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public partial class Swipe : ActionSet
	{
		
		/// <summary>
		/// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
		/// </summary>
		/// <param name="_station">The id of the sign-in station.</param>
		/// <param name="_user">The user's card number.</param>


		public ActionResult Saveanonym(Guid _station, string _user
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.saveanonym", new {_station, _user
});
		}

		
		/// <summary>
		/// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
		/// </summary>
		/// <param name="_station">The id of the sign-in station.</param>
		/// <param name="_user">The user's card number.</param>
		/// <param name="_time">The date and time of the swipe. Now is considered if omitted.</param>
		/// <param name="_session">The id of the session whose swipe has to be saved.</param>
		/// <param name="_type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>


		public ActionResult Saveanonym(Guid _station, string _user, DateTime _time, Guid _session, SwipeType _type
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.saveanonym", new {_station, _user, _time, _session, _type
});
		}

		

	}
}


