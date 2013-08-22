using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public static partial class Holiday
	{
		
		/// <summary>
		/// List holidays.  This action requires authentication.
		/// </summary>
		/// <param name="@semester">The semester to get holidays from.</param>


		public static ActionResult List(Guid @semester
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "holiday.list", new {@semester
});
		}

		

	}
}


