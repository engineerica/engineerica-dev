using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Cards.
	/// </summary>
	public static partial class Card
	{
		
		/// <summary>
		/// Creates a new card with an unused number and assigns it to whom it corresponds.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference where card has to be saved.</param>


		public static ActionResult Autoassign(string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "card.autoassign", new {@conference
});
		}

		
		/// <summary>
		/// Creates a new card with an unused number and assigns it to whom it corresponds
		/// </summary>
		/// <param name="@conference">The id of the conference where card has to be saved.</param>
		/// <param name="@assignedto">The user id that a new random card has to be assigned to.</param>


		public static ActionResult Autoassign(string @conference, string @assignedto
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "card.autoassign", new {@conference, @assignedto
});
		}

		

	}
}


