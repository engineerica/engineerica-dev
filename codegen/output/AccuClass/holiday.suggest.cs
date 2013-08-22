using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public static partial class Holiday
	{
		
		/// <summary>
		/// List holiday suggestions in the given semester.  This action requires authentication.
		/// </summary>
		/// <param name="@semester">The semester to get holidays from.</param>


		public static ActionResult Suggest(Guid @semester
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "holiday.suggest", new {@semester
});
		}

		

	}
}


