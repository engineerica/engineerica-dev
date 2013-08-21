using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public partial class Class : ActionSet
	{
		
		/// <summary>
		/// List classes.  This action requires authentication.
		/// </summary>
		/// <param name="_from">The first record to return.</param>
		/// <param name="_count">The max number of records to return.</param>


		public ActionResult List(int _from, int _count
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "class.list", new {_from, _count
});
		}

		

	}
}


