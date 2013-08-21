using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public partial class Semester : ActionSet
	{
		
		/// <summary>
		/// Gets a semester by Id.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the semester to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "semester.get", new {_id
});
		}

		

	}
}


