using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Departments.
	/// </summary>
	public static partial class Department
	{
		
		/// <summary>
		/// Saves department.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the department.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "department.save", new {@name
});
		}

		
		/// <summary>
		/// Saves department
		/// </summary>
		/// <param name="@name">The name of the department.</param>
		/// <param name="@id">The id of the department save (leave empty to create a new one).</param>
		/// <param name="@details">The details of the department.</param>


		public static ActionResult Save(string @name, Guid @id, string @details
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "department.save", new {@name, @id, @details
});
		}

		

	}
}


