using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public partial class Holiday : ActionSet
	{
		
		/// <summary>
		/// List holidays.  This action requires authentication.
		/// </summary>
		/// <param name="_semester">The semester to get holidays from.</param>


		public ActionResult List(Guid _semester
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "holiday.list", new {_semester
});
		}

		

	}
}


