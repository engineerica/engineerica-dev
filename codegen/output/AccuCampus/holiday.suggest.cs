using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public static partial class Holiday
	{
		
		/// <summary>
		/// List holiday suggestions in the given term.  This action requires authentication.
		/// </summary>
		/// <param name="@term">The term to get holidays from.</param>


		public static ActionResult Suggest(Guid @term
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "holiday.suggest", new {@term
});
		}

		

	}
}


