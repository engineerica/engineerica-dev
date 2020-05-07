using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Cards.
	/// </summary>
	public static partial class Card
	{
		
		/// <summary>
		/// Saves card.  This action requires authentication.
		/// </summary>


		public static ActionResult Save(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "card.save", new {
});
		}

		
		/// <summary>
		/// Saves card
		/// </summary>
		/// <param name="@id">The id of the card to save (leave empty to create a new one).</param>
		/// <param name="@number">The number of the card.</param>
		/// <param name="@assignedto">The user id that this card has been assigned to.</param>
		/// <param name="@conference">The id of the conference where card has to be saved.</param>


		public static ActionResult Save(Guid @id, string @number, string @assignedto, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "card.save", new {@id, @number, @assignedto, @conference
});
		}

		

	}
}


