using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "holiday.save", new {@daysoff
});
		}

		

	}
}


