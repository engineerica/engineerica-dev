using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classrooms.
	/// </summary>
	public partial class Classroom : ActionSet
	{
		
		/// <summary>
		/// List classrooms.  This action requires authentication.
		/// </summary>
		/// <param name="_from">The first record to return.</param>
		/// <param name="_count">The max number of records to return.</param>


		public ActionResult List(int _from, int _count
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "classroom.list", new {_from, _count
});
		}

		

	}
}


