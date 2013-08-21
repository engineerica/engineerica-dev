using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public partial class Department : ActionSet
	{
		
		/// <summary>
		/// Gets a department by Id.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the department to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "department.get", new {_id
});
		}

		

	}
}


