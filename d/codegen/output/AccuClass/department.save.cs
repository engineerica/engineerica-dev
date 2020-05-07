using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public static partial class Department
	{
		
		/// <summary>
		/// Saves a department.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the department.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "department.save", new {@name
});
		}

		
		/// <summary>
		/// Saves a department
		/// </summary>
		/// <param name="@name">The name of the department.</param>
		/// <param name="@id">The id of the department to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "department.save", new {@name, @id
});
		}

		

	}
}


