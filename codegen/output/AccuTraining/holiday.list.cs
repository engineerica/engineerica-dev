using System;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "holiday.list", new {@term
});
		}

		

	}
}


