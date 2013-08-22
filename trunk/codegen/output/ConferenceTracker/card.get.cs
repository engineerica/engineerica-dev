using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Cards.
	/// </summary>
	public static partial class Card
	{
		
		/// <summary>
		/// Get card.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the card to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "card.get", new {@id
});
		}

		

	}
}


