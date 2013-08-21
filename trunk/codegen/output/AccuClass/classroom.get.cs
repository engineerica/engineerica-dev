using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public partial class Classroom : ActionSet
	{
		
		/// <summary>
		/// Gets a classroom by Id.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the classroom to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "classroom.get", new {_id
});
		}

		

	}
}


