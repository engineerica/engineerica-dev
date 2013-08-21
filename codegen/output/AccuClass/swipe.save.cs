using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public partial class Swipe : ActionSet
	{
		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="_type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="_device">The unique id of the device whose swipe has to be saved.</param>


		public ActionResult Save(SwipeType _type, string _device
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.save", new {_type, _device
});
		}

		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log
		/// </summary>
		/// <param name="_type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="_device">The unique id of the device whose swipe has to be saved.</param>
		/// <param name="_time">The date and time of the swipe. Now is considered if omitted.</param>
		/// <param name="_cardnumber">The number of the swipped card, used if the id was not specified.</param>
		/// <param name="_session">The id of the session whose swipe has to be saved.</param>
		/// <param name="_classroom">The id of the classroom whose swipe has to be saved.</param>
		/// <param name="_devicename">The name of the device whose swipe has to be saved.</param>
		/// <param name="_metadata">The swipe's metadata in JSON format.</param>


		public ActionResult Save(SwipeType _type, string _device, DateTime _time, string _cardnumber, Guid _session, Guid _classroom, string _devicename, string _metadata
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.save", new {_type, _device, _time, _cardnumber, _session, _classroom, _devicename, _metadata
});
		}

		

	}
}


