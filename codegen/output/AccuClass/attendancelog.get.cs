using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Gets an attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the attendance log to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.get", new {_id
});
		}

		

	}
}


