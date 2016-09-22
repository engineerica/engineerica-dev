using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Renders a specific newsletter to HTML. The result will be in HTML..  This action requires authentication.
		/// </summary>
		/// <param name="@id">Id of the newsletter to get.</param>


		public static ActionResult Render(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.render", new {@id
});
		}

		
		/// <summary>
		/// Renders a specific newsletter to HTML. The result will be in HTML.
		/// </summary>
		/// <param name="@id">Id of the newsletter to get.</param>
		/// <param name="@includescripts">Pipe separated list of scripts to include.</param>
		/// <param name="@includecss">Pipe separated list of css files to include.</param>
		/// <param name="@includeavailable">True to also render the available ads.</param>


		public static ActionResult Render(Guid @id, string @includescripts, string @includecss, bool @includeavailable
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.render", new {@id, @includescripts, @includecss, @includeavailable
});
		}

		

	}
}


