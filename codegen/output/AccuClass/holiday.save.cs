using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Holidays.
	/// </summary>
	public partial class Holiday : ActionSet
	{
		
		/// <summary>
		/// Saves a list of holidays.  This action requires authentication.
		/// </summary>
		/// <param name="_daysoff">A json list of names and dates.</param>


		public ActionResult Save(string _daysoff
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "holiday.save", new {_daysoff
});
		}

		

	}
}


