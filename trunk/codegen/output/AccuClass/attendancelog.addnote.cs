using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Adds a note to an attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the attendance log.</param>
		/// <param name="@text">The text of the note to add.</param>


		public static ActionResult Addnote(Guid @id, string @text
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "attendancelog.addnote", new {@id, @text
});
		}

		

	}
}


