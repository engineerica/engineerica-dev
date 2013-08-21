using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public partial class Class : ActionSet
	{
		
		/// <summary>
		/// Gets and repairs class sessions according to their schedule.  This action requires authentication.
		/// </summary>
		/// <param name="_classid">The id of the class to check.</param>
		/// <param name="_autorepair">True to automatically fix the invalid sessions.</param>


		public ActionResult Checksessions(Guid _classid, bool _autorepair
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "class.checksessions", new {_classid, _autorepair
});
		}

		

	}
}


