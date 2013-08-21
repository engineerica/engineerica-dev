using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public partial class Enrollment : ActionSet
	{
		
		/// <summary>
		/// Gets the enrollment for the specified class.  This action requires authentication.
		/// </summary>
		/// <param name="_classid">The id of the class to get enrollment.</param>


		public ActionResult Getclass(Guid _classid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "enrollment.getclass", new {_classid
});
		}

		

	}
}


