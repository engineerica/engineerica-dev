using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public static partial class Holiday
	{
		
		/// <summary>
		/// Saves a list of holidays.  This action requires authentication.
		/// </summary>
		/// <param name="@daysoff">A json list of names and dates.</param>


		public static ActionResult Save(string @daysoff
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "holiday.save", new {@daysoff
});
		}

		

	}
}


