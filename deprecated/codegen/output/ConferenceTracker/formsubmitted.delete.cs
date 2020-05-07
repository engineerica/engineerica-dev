using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Formsubmitteds.
	/// </summary>
	public static partial class Formsubmitted
	{
		
		/// <summary>
		/// Delete a submitted form.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the submitted form to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "formsubmitted.delete", new {@id
});
		}

		

	}
}


