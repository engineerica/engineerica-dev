using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Deletes an attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the attendance log to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.delete", new {_id
});
		}

		

	}
}


