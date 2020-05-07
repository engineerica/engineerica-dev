using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Enrollments.
	/// </summary>
	public static partial class Enrollment
	{
		
		/// <summary>
		/// Gets the enrollment for the specified class.  This action requires authentication.
		/// </summary>
		/// <param name="@classid">The id of the class to get enrollment.</param>


		public static ActionResult Getclass(Guid @classid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "enrollment.getclass", new {@classid
});
		}

		

	}
}


