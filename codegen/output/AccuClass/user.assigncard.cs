using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// Assigns a card to a student.  This action requires authentication.
		/// </summary>
		/// <param name="_student">The id of the user to assign the card.</param>
		/// <param name="_card">The card number (can be text) of the student.</param>


		public ActionResult Assigncard(Guid _student, string _card
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.assigncard", new {_student, _card
});
		}

		

	}
}


