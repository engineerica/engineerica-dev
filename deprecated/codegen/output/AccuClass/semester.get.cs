using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public static partial class Semester
	{
		
		/// <summary>
		/// Gets a semester by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the semester to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "semester.get", new {@id
});
		}

		

	}
}


