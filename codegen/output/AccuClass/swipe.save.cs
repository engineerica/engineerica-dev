using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="@device">The unique id of the device whose swipe has to be saved.</param>


		public static ActionResult Save(SwipeType @type, string @device
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.save", new {@type, @device
});
		}

		
		/// <summary>
		/// Creates a new swipe, and if possible, creates the attendance log
		/// </summary>
		/// <param name="@type">Specifies the attendance type (0 = Sign-In, 1 = Sign-Out).</param>
		/// <param name="@device">The unique id of the device whose swipe has to be saved.</param>
		/// <param name="@time">The date and time of the swipe. Now is considered if omitted.</param>
		/// <param name="@cardnumber">The number of the swipped card, used if the id was not specified.</param>
		/// <param name="@session">The id of the session whose swipe has to be saved.</param>
		/// <param name="@classroom">The id of the classroom whose swipe has to be saved.</param>
		/// <param name="@clazz">The id of the clazz whose swipe has to be saved.</param>
		/// <param name="@devicename">The name of the device whose swipe has to be saved.</param>
		/// <param name="@metadata">The swipe's metadata in JSON format.</param>


		public static ActionResult Save(SwipeType @type, string @device, DateTime @time, string @cardnumber, Guid @session, Guid @classroom, Guid @clazz, string @devicename, string @metadata
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.save", new {@type, @device, @time, @cardnumber, @session, @classroom, @clazz, @devicename, @metadata
});
		}

		

	}
}


