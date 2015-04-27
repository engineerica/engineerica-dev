using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Goodies.
	/// </summary>
	public static partial class Goodie
	{
		
		/// <summary>
		/// Saves handout.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the handout.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "goodie.save", new {@name
});
		}

		
		/// <summary>
		/// Saves handout
		/// </summary>
		/// <param name="@name">The name of the handout.</param>
		/// <param name="@id">The id of the handout to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the handout.</param>
		/// <param name="@conference">The id of the conference on which the handout is going to be given.</param>


		public static ActionResult Save(string @name, Guid @id, string @description, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "goodie.save", new {@name, @id, @description, @conference
});
		}

		

	}
}


