using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public static partial class Classroom
	{
		
		/// <summary>
		/// Gets a classroom by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the classroom to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "classroom.get", new {@id
});
		}

		

	}
}


