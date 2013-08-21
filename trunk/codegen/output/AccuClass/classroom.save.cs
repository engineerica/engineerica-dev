using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public partial class Classroom : ActionSet
	{
		
		/// <summary>
		/// Saves a classroom.  This action requires authentication.
		/// </summary>
		/// <param name="_name">The name of the classroom.</param>


		public ActionResult Save(string _name
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "classroom.save", new {_name
});
		}

		
		/// <summary>
		/// Saves a classroom
		/// </summary>
		/// <param name="_name">The name of the classroom.</param>
		/// <param name="_id">The id of the classroom to save (leave empty to create a new one).</param>
		/// <param name="_location">The location of the classroom, free text.</param>


		public ActionResult Save(string _name, Guid _id, string _location
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "classroom.save", new {_name, _id, _location
});
		}

		

	}
}


