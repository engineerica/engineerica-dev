using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public static partial class Holiday
	{
		
		/// <summary>
		/// List holidays.  This action requires authentication.
		/// </summary>
		/// <param name="@term">The term to get holidays from.</param>


		public static ActionResult List(Guid @term
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "holiday.list", new {@term
});
		}

		

	}
}


