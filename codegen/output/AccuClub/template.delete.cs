using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Deletes a template.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the template to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "template.delete", new {@id
});
		}

		

	}
}


