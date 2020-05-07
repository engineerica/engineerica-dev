using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Deletes a swipe.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the swipe to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.delete", new {@id
});
		}

		

	}
}


