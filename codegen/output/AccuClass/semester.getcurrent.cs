using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Semesters.
	/// </summary>
	public static partial class Semester
	{
		
		/// <summary>
		/// Gets the current semester (or the next if there is not an active one).  This action requires authentication.
		/// </summary>


		public static ActionResult Getcurrent(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "semester.getcurrent", new {
});
		}

		

	}
}


