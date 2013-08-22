using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public static partial class Department
	{
		
		/// <summary>
		/// Deletes a department.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the department to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "department.delete", new {@id
});
		}

		

	}
}


