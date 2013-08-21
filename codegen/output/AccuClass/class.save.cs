using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public partial class Class : ActionSet
	{
		
		/// <summary>
		/// Saves a class.  This action requires authentication.
		/// </summary>
		/// <param name="_code">The unique code of the class.</param>
		/// <param name="_name">The name of the class.</param>
		/// <param name="_semester">The email of the class.</param>


		public ActionResult Save(string _code, string _name, string _semester
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "class.save", new {_code, _name, _semester
});
		}

		
		/// <summary>
		/// Saves a class
		/// </summary>
		/// <param name="_code">The unique code of the class.</param>
		/// <param name="_name">The name of the class.</param>
		/// <param name="_semester">The email of the class.</param>
		/// <param name="_id">The id of the class to save (leave empty to create a new one).</param>
		/// <param name="_department">The department id .</param>
		/// <param name="_schedule">The schedule of the class, a JSON-formatted array. Each item must contain an action (set/remove) and the schedule properties, as returned by class.get.</param>
		/// <param name="_instructors">The Id of the instructor, you can specify multiple separating the Ids by a comma.</param>


		public ActionResult Save(string _code, string _name, string _semester, Guid _id, string _department, string _schedule, string _instructors
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "class.save", new {_code, _name, _semester, _id, _department, _schedule, _instructors
});
		}

		

	}
}


