using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Usertasks.
	/// </summary>
	public static partial class Usertask
	{
		
		/// <summary>
		/// Lists task types or definitions
		/// </summary>


		public static ActionResult Listdefs(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "usertask.listdefs", new {
});
		}

		

	}
}


