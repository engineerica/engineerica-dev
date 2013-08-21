using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Gets the attendance statuses for the whole class.  This action requires authentication.
		/// </summary>
		/// <param name="_classid">The id of the class whose students attendance have to be returned.</param>


		public ActionResult Listclass(Guid _classid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.listclass", new {_classid
});
		}

		

	}
}


