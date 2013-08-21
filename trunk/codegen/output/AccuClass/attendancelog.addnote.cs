using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public partial class Attendancelog : ActionSet
	{
		
		/// <summary>
		/// Adds a note to an attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the attendance log.</param>
		/// <param name="_text">The text of the note to add.</param>


		public ActionResult Addnote(Guid _id, string _text
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "attendancelog.addnote", new {_id, _text
});
		}

		

	}
}


