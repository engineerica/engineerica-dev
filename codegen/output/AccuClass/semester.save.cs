using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public static partial class Semester
	{
		
		/// <summary>
		/// Saves a semester.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the semester.</param>
		/// <param name="@start">The date when the semester starts.</param>
		/// <param name="@end">The date when the semester ends.</param>


		public static ActionResult Save(string @name, DateTime @start, DateTime @end
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "semester.save", new {@name, @start, @end
});
		}

		
		/// <summary>
		/// Saves a semester
		/// </summary>
		/// <param name="@name">The name of the semester.</param>
		/// <param name="@start">The date when the semester starts.</param>
		/// <param name="@end">The date when the semester ends.</param>
		/// <param name="@id">The id of the semester to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, DateTime @start, DateTime @end, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "semester.save", new {@name, @start, @end, @id
});
		}

		

	}
}


