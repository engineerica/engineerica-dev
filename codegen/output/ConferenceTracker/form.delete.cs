using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Forms.
	/// </summary>
	public static partial class Form
	{
		
		/// <summary>
		/// Deletes a form.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the form to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "form.delete", new {@id
});
		}

		

	}
}


