using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Assigns a card to a student.  This action requires authentication.
		/// </summary>
		/// <param name="@student">The id of the user to assign the card.</param>
		/// <param name="@card">The card number (can be text) of the student.</param>


		public static ActionResult Assigncard(Guid @student, string @card
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.assigncard", new {@student, @card
});
		}

		

	}
}


