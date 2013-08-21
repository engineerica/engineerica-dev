using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public partial class Department : ActionSet
	{
		
		/// <summary>
		/// Saves a department.  This action requires authentication.
		/// </summary>
		/// <param name="_name">The name of the department.</param>


		public ActionResult Save(string _name
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "department.save", new {_name
});
		}

		
		/// <summary>
		/// Saves a department
		/// </summary>
		/// <param name="_name">The name of the department.</param>
		/// <param name="_id">The id of the department to save (leave empty to create a new one).</param>


		public ActionResult Save(string _name, Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "department.save", new {_name, _id
});
		}

		

	}
}


