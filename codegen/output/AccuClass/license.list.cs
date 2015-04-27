using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Licenses.
	/// </summary>
	public static partial class License
	{
		
		/// <summary>
		/// Lists the licenses
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "license.list", new {
});
		}

		

	}
}


