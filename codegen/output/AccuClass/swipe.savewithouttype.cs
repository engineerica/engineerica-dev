using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Resolve the swipe type and save it creating the corresponding attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@device">The unique id of the device whose swipe has to be saved.</param>


		public static ActionResult Savewithouttype(string @device
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.savewithouttype", new {@device
});
		}

		
		/// <summary>
		/// Resolve the swipe type and save it creating the corresponding attendance log
		/// </summary>
		/// <param name="@device">The unique id of the device whose swipe has to be saved.</param>
		/// <param name="@time">The date and time of the swipe. Now is considered if omitted.</param>
		/// <param name="@cardnumber">The user's card number.</param>
		/// <param name="@classroom">The id of the classroom whose swipe has to be saved.</param>
		/// <param name="@session">The id of the session whose swipe has to be saved.</param>
		/// <param name="@devicename">The name of the device whose swipe has to be saved.</param>


		public static ActionResult Savewithouttype(string @device, DateTime @time, string @cardnumber, Guid @classroom, Guid @session, string @devicename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.savewithouttype", new {@device, @time, @cardnumber, @classroom, @session, @devicename
});
		}

		

	}
}


