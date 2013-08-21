using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public partial class Department : ActionSet
	{
		
		/// <summary>
		/// Deletes a department.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the department to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "department.delete", new {_id
});
		}

		

	}
}


