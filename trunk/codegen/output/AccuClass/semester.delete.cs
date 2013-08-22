using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public static partial class Semester
	{
		
		/// <summary>
		/// Deletes a semester.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the semester to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "semester.delete", new {@id
});
		}

		

	}
}


