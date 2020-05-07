using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public static partial class Classroom
	{
		
		/// <summary>
		/// Deletes a classroom.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the classroom to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "classroom.delete", new {@id
});
		}

		

	}
}


