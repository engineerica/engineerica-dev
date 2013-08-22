using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Cards.
	/// </summary>
	public static partial class Card
	{
		
		/// <summary>
		/// Deletes a card.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the card to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "card.delete", new {@id
});
		}

		

	}
}


