using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public partial class Class : ActionSet
	{
		
		/// <summary>
		/// Deletes a class.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the class to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "class.delete", new {_id
});
		}

		

	}
}


