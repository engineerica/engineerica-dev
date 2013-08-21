using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public partial class Semester : ActionSet
	{
		
		/// <summary>
		/// Saves a semester.  This action requires authentication.
		/// </summary>
		/// <param name="_name">The name of the semester.</param>
		/// <param name="_start">The date when the semester starts.</param>
		/// <param name="_end">The date when the semester ends.</param>


		public ActionResult Save(string _name, DateTime _start, DateTime _end
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "semester.save", new {_name, _start, _end
});
		}

		
		/// <summary>
		/// Saves a semester
		/// </summary>
		/// <param name="_name">The name of the semester.</param>
		/// <param name="_start">The date when the semester starts.</param>
		/// <param name="_end">The date when the semester ends.</param>
		/// <param name="_id">The id of the semester to save (leave empty to create a new one).</param>


		public ActionResult Save(string _name, DateTime _start, DateTime _end, Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "semester.save", new {_name, _start, _end, _id
});
		}

		

	}
}


