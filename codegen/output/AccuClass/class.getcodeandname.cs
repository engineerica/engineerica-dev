using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Classs.
	/// </summary>
	public static partial class Class
	{
		
		/// <summary>
		/// Gets the code and name of a class.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the class to get.</param>


		public static ActionResult Getcodeandname(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "class.getcodeandname", new {@id
});
		}

		

	}
}


