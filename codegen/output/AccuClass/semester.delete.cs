using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public partial class Semester : ActionSet
	{
		
		/// <summary>
		/// Deletes a semester.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the semester to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "semester.delete", new {_id
});
		}

		

	}
}


