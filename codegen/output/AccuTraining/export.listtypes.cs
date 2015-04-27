using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Exports.
	/// </summary>
	public static partial class Export
	{
		
		/// <summary>
		/// Lists available export types.  This action requires authentication.
		/// </summary>


		public static ActionResult Listtypes(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "export.listtypes", new {
});
		}

		

	}
}


