using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public partial class Class : ActionSet
	{
		
		/// <summary>
		/// Gets a class data.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the class to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "class.get", new {_id
});
		}

		

	}
}


