using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public static partial class Class
	{
		
		/// <summary>
		/// Deletes a class.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the class to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.delete", new {@id
});
		}

		

	}
}


