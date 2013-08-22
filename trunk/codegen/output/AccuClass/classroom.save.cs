using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public static partial class Classroom
	{
		
		/// <summary>
		/// Saves a classroom.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the classroom.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "classroom.save", new {@name
});
		}

		
		/// <summary>
		/// Saves a classroom
		/// </summary>
		/// <param name="@name">The name of the classroom.</param>
		/// <param name="@id">The id of the classroom to save (leave empty to create a new one).</param>
		/// <param name="@location">The location of the classroom, free text.</param>


		public static ActionResult Save(string @name, Guid @id, string @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "classroom.save", new {@name, @id, @location
});
		}

		

	}
}


