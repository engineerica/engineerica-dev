using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public static partial class Department
	{
		
		/// <summary>
		/// Gets a department by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the department to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "department.get", new {@id
});
		}

		

	}
}


