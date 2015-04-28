using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Saves the layout of a template.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the template whose layout needs to be saved.</param>
		/// <param name="@layout">The template's layout (in JSON).</param>


		public static ActionResult Savelayout(Guid @id, string @layout
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "template.savelayout", new {@id, @layout
});
		}

		

	}
}


