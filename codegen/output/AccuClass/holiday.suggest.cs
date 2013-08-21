using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public partial class Holiday : ActionSet
	{
		
		/// <summary>
		/// List holiday suggestions in the given semester.  This action requires authentication.
		/// </summary>
		/// <param name="_semester">The semester to get holidays from.</param>


		public ActionResult Suggest(Guid _semester
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "holiday.suggest", new {_semester
});
		}

		

	}
}


