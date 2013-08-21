using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public partial class Classroom : ActionSet
	{
		
		/// <summary>
		/// Deletes a classroom.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the classroom to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "classroom.delete", new {_id
});
		}

		

	}
}


