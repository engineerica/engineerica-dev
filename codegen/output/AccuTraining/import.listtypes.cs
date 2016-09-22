using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Imports.
	/// </summary>
	public static partial class Import
	{
		
		/// <summary>
		/// Lists available import types.  This action requires authentication.
		/// </summary>


		public static ActionResult Listtypes(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "import.listtypes", new {
});
		}

		

	}
}


