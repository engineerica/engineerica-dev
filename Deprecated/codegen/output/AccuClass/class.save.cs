using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public static partial class Class
	{
		
		/// <summary>
		/// Saves a class.  This action requires authentication.
		/// </summary>
		/// <param name="@code">The unique code of the class.</param>
		/// <param name="@name">The name of the class.</param>
		/// <param name="@semester">The email of the class.</param>


		public static ActionResult Save(string @code, string @name, string @semester
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.save", new {@code, @name, @semester
});
		}

		
		/// <summary>
		/// Saves a class
		/// </summary>
		/// <param name="@code">The unique code of the class.</param>
		/// <param name="@name">The name of the class.</param>
		/// <param name="@semester">The email of the class.</param>
		/// <param name="@id">The id of the class to save (leave empty to create a new one).</param>
		/// <param name="@department">The department id .</param>
		/// <param name="@schedule">The schedule of the class, a JSON-formatted array. Each item must contain an action (set/remove) and the schedule properties, as returned by class.get.</param>
		/// <param name="@meetings">The meetings of the class, a JSON-formatted array. Each item must contain an action (set/remove) and the meeting properties, as returned by class.get.</param>
		/// <param name="@instructors">The Id of the instructor, you can specify multiple separating the Ids by a comma.</param>
		/// <param name="@checksessions">Specifies if class sessions should be checked automatically after saving the class.</param>


		public static ActionResult Save(string @code, string @name, string @semester, Guid @id, string @department, string @schedule, string @meetings, string @instructors, bool @checksessions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.save", new {@code, @name, @semester, @id, @department, @schedule, @meetings, @instructors, @checksessions
});
		}

		

	}
}


